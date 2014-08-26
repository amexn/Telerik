﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Core.Metadata.Edm.Provider
{
    internal static class EdmProviderManifestSpatialFunctions
    {
        internal static void AddFunctions(EdmProviderManifestFunctionBuilder functions)
        {
            // Geometry Functions
            functions.AddFunction(PrimitiveTypeKind.Geometry, "GeometryFromText", PrimitiveTypeKind.String, "geometryText");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryFromText", PrimitiveTypeKind.String, "geometryText", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryPointFromText", PrimitiveTypeKind.String, "pointText", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryLineFromText", PrimitiveTypeKind.String, "lineText", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryPolygonFromText", PrimitiveTypeKind.String, "polygonText", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryMultiPointFromText", PrimitiveTypeKind.String, "multiPointText",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryMultiLineFromText", PrimitiveTypeKind.String, "multiLineText", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryMultiPolygonFromText", PrimitiveTypeKind.String, "multiPolygonText",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryCollectionFromText", PrimitiveTypeKind.String, "geometryCollectionText",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "GeometryFromBinary", PrimitiveTypeKind.Binary, "geometryBytes");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryFromBinary", PrimitiveTypeKind.Binary, "geometryBytes", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryPointFromBinary", PrimitiveTypeKind.Binary, "pointBytes", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryLineFromBinary", PrimitiveTypeKind.Binary, "lineBytes", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryPolygonFromBinary", PrimitiveTypeKind.Binary, "polygonBytes", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryMultiPointFromBinary", PrimitiveTypeKind.Binary, "multiPointBytes",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryMultiLineFromBinary", PrimitiveTypeKind.Binary, "multiLineBytes",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryMultiPolygonFromBinary", PrimitiveTypeKind.Binary, "multiPolygonBytes",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryCollectionFromBinary", PrimitiveTypeKind.Binary, "geometryCollectionBytes",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "GeometryFromGml", PrimitiveTypeKind.String, "geometryGml");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "GeometryFromGml", PrimitiveTypeKind.String, "geometryGml", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(PrimitiveTypeKind.Int32, "CoordinateSystemId", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.String, "SpatialTypeName", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Int32, "SpatialDimension", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "SpatialEnvelope", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Binary, "AsBinary", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.String, "AsGml", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.String, "AsText", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Boolean, "IsEmptySpatial", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Boolean, "IsSimpleGeometry", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "SpatialBoundary", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Boolean, "IsValidGeometry", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialEquals", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialDisjoint", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialIntersects", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialTouches", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialCrosses", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialWithin", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialContains", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialOverlaps", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialRelate", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2", PrimitiveTypeKind.String, "matrix");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "SpatialBuffer", PrimitiveTypeKind.Geometry, "geometryValue", PrimitiveTypeKind.Double,
                "distance");
            functions.AddFunction(
                PrimitiveTypeKind.Double, "Distance", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "SpatialConvexHull", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "SpatialIntersection", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "SpatialUnion", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "SpatialDifference", PrimitiveTypeKind.Geometry, "geometryValue1", PrimitiveTypeKind.Geometry,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "SpatialSymmetricDifference", PrimitiveTypeKind.Geometry, "geometryValue1",
                PrimitiveTypeKind.Geometry, "geometryValue2");
            functions.AddFunction(PrimitiveTypeKind.Int32, "SpatialElementCount", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "SpatialElementAt", PrimitiveTypeKind.Geometry, "geometryValue", PrimitiveTypeKind.Int32,
                "nValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "XCoordinate", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "YCoordinate", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "Elevation", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "Measure", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "SpatialLength", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "StartPoint", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "EndPoint", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Boolean, "IsClosedSpatial", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Boolean, "IsRing", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Int32, "PointCount", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "PointAt", PrimitiveTypeKind.Geometry, "geometryValue", PrimitiveTypeKind.Int32, "nValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "Area", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "Centroid", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "PointOnSurface", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Geometry, "ExteriorRing", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(PrimitiveTypeKind.Int32, "InteriorRingCount", PrimitiveTypeKind.Geometry, "geometryValue");
            functions.AddFunction(
                PrimitiveTypeKind.Geometry, "InteriorRingAt", PrimitiveTypeKind.Geometry, "geometryValue", PrimitiveTypeKind.Int32, "nValue");

            // Geography Functions
            functions.AddFunction(PrimitiveTypeKind.Geography, "GeographyFromText", PrimitiveTypeKind.String, "geographyText");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyFromText", PrimitiveTypeKind.String, "geographyText", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyPointFromText", PrimitiveTypeKind.String, "pointText", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyLineFromText", PrimitiveTypeKind.String, "lineText", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyPolygonFromText", PrimitiveTypeKind.String, "polygonText", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyMultiPointFromText", PrimitiveTypeKind.String, "multiPointText",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyMultiLineFromText", PrimitiveTypeKind.String, "multiLineText",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyMultiPolygonFromText", PrimitiveTypeKind.String, "multiPolygonText",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyCollectionFromText", PrimitiveTypeKind.String, "geographyCollectionText",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyFromBinary", PrimitiveTypeKind.Binary, "geographyBytes", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(PrimitiveTypeKind.Geography, "GeographyFromBinary", PrimitiveTypeKind.Binary, "geographyBytes");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyPointFromBinary", PrimitiveTypeKind.Binary, "pointBytes", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyLineFromBinary", PrimitiveTypeKind.Binary, "lineBytes", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyPolygonFromBinary", PrimitiveTypeKind.Binary, "polygonBytes", PrimitiveTypeKind.Int32,
                "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyMultiPointFromBinary", PrimitiveTypeKind.Binary, "multiPointBytes",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyMultiLineFromBinary", PrimitiveTypeKind.Binary, "multiLineBytes",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyMultiPolygonFromBinary", PrimitiveTypeKind.Binary, "multiPolygonBytes",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyCollectionFromBinary", PrimitiveTypeKind.Binary, "geographyCollectionBytes",
                PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(PrimitiveTypeKind.Geography, "GeographyFromGml", PrimitiveTypeKind.String, "geographyGml");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "GeographyFromGml", PrimitiveTypeKind.String, "geographyGml", PrimitiveTypeKind.Int32, "srid");
            functions.AddFunction(PrimitiveTypeKind.Int32, "CoordinateSystemId", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.String, "SpatialTypeName", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Int32, "SpatialDimension", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Binary, "AsBinary", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.String, "AsGml", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.String, "AsText", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Boolean, "IsEmptySpatial", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialEquals", PrimitiveTypeKind.Geography, "geographyValue1", PrimitiveTypeKind.Geography,
                "geographyValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialDisjoint", PrimitiveTypeKind.Geography, "geographyValue1", PrimitiveTypeKind.Geography,
                "geographyValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Boolean, "SpatialIntersects", PrimitiveTypeKind.Geography, "geographyValue1", PrimitiveTypeKind.Geography,
                "geographyValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "SpatialBuffer", PrimitiveTypeKind.Geography, "geographyValue", PrimitiveTypeKind.Double,
                "distance");
            functions.AddFunction(
                PrimitiveTypeKind.Double, "Distance", PrimitiveTypeKind.Geography, "geographyValue1", PrimitiveTypeKind.Geography,
                "geographyValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "SpatialIntersection", PrimitiveTypeKind.Geography, "geographyValue1",
                PrimitiveTypeKind.Geography, "geographyValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "SpatialUnion", PrimitiveTypeKind.Geography, "geographyValue1", PrimitiveTypeKind.Geography,
                "geographyValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "SpatialDifference", PrimitiveTypeKind.Geography, "geometryValue1", PrimitiveTypeKind.Geography,
                "geometryValue2");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "SpatialSymmetricDifference", PrimitiveTypeKind.Geography, "geometryValue1",
                PrimitiveTypeKind.Geography, "geometryValue2");
            functions.AddFunction(PrimitiveTypeKind.Int32, "SpatialElementCount", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "SpatialElementAt", PrimitiveTypeKind.Geography, "geographyValue", PrimitiveTypeKind.Int32,
                "nValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "Latitude", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "Longitude", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "Elevation", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "Measure", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "SpatialLength", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Geography, "StartPoint", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Geography, "EndPoint", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Boolean, "IsClosedSpatial", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(PrimitiveTypeKind.Int32, "PointCount", PrimitiveTypeKind.Geography, "geographyValue");
            functions.AddFunction(
                PrimitiveTypeKind.Geography, "PointAt", PrimitiveTypeKind.Geography, "geographyValue", PrimitiveTypeKind.Int32, "nValue");
            functions.AddFunction(PrimitiveTypeKind.Double, "Area", PrimitiveTypeKind.Geography, "geographyValue");
        }
    }
}
