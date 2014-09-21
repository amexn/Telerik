// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.Design.Model.Designer
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml.Linq;

    internal class DesignerInfoPropertySet : EFElement
    {
        internal static readonly string ElementName = "DesignerInfoPropertySet";
        protected Dictionary<string, DesignerProperty> _designerProperties = new Dictionary<string, DesignerProperty>();

        internal DesignerInfoPropertySet(DesignerInfo parent, XElement element)
            : base(parent, element)
        {
        }

        internal bool TryGetDesignerProperty(string propertyName, out DesignerProperty designerProperty)
        {
            return _designerProperties.TryGetValue(propertyName, out designerProperty);
        }

        internal void AddDesignerProperty(string propertyName, DesignerProperty prop)
        {
            _designerProperties.Add(propertyName, prop);
        }

        #region overrides

        // we unfortunately get a warning from the compiler when we use the "base" keyword in "iterator" types generated by using the
        // "yield return" keyword.  By adding this method, I was able to get around this.  Unfortunately, I wasn't able to figure out
        // a way to implement this once and have derived classes share the implementation (since the "base" keyword is resolved at 
        // compile-time and not at runtime.
        private IEnumerable<EFObject> BaseChildren
        {
            get { return base.Children; }
        }

        internal override IEnumerable<EFObject> Children
        {
            get
            {
                foreach (var efobj in BaseChildren)
                {
                    yield return efobj;
                }

                foreach (var prop in _designerProperties.Values)
                {
                    yield return prop;
                }
            }
        }

        protected override void OnChildDeleted(EFContainer efContainer)
        {
            var child2 = efContainer as DesignerProperty;
            if (child2 != null)
            {
                var propEnum = _designerProperties.GetEnumerator();
                while (propEnum.MoveNext())
                {
                    if (propEnum.Current.Value == child2)
                    {
                        _designerProperties.Remove(propEnum.Current.Key);
                        break;
                    }
                }
                return;
            }

            base.OnChildDeleted(efContainer);
        }

#if DEBUG
        internal override ICollection<string> MyAttributeNames()
        {
            var s = base.MyAttributeNames();
            return s;
        }
#endif

#if DEBUG
        internal override ICollection<string> MyChildElementNames()
        {
            var s = base.MyChildElementNames();
            s.Add(DesignerProperty.ElementName);
            return s;
        }
#endif

        protected override void PreParse()
        {
            Debug.Assert(State != EFElementState.Parsed, "this object should not already be in the parsed state");

            if (_designerProperties != null)
            {
                if (_designerProperties.Values.Count > 0)
                {
                    foreach (var prop in _designerProperties.Values)
                    {
                        prop.Dispose();
                    }
                }
                _designerProperties.Clear();
            }

            base.PreParse();
        }

        [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
        internal override bool ParseSingleElement(ICollection<XName> unprocessedElements, XElement elem)
        {
            // we leave the parsing of properties to the subclasses of BaseDesignerModel
            if (elem.Name.LocalName == "DesignerProperty")
            {
                var propertyName = elem.Attribute(EFNameableItem.AttributeName).Value;
                // Fix for bug 390580 - only include DesignerProperty if one with that name
                // does not already exist (otherwise Dictionary throws when you attempt to add
                // it which casues VS to crash)
                if (false == _designerProperties.ContainsKey(propertyName))
                {
                    var prop = new DesignerProperty(this, elem);
                    prop.Parse(unprocessedElements);
                    AddDesignerProperty(propertyName, prop);
                }
            }
            else
            {
                return base.ParseSingleElement(unprocessedElements, elem);
            }

            return true;
        }

        #endregion
    }
}