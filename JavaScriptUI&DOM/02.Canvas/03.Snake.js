function snake() {
    CELL_SIZE = 10;
    FIELD_WIDTH = 600;
    FIELD_HEIGHT = 450;
    SNAKE_INITIAL_LENGTH = 4;
    LEFT_ARROW_KEY_NUMBER = 37;
    UP_ARROW_KEY_NUMBER = 38;
    RIGHT_ARROW_KEY_NUMBER = 39;
    DOWN_ARROW_KEY_NUMBER = 40;
    UP_DIRECTION = 'up';
    DOWN_DIRECTION = 'down';
    LEFT_DIRECTION = 'left';
    RIGHT_DIRECTION = 'right';

    var canvas = document.getElementById('canvas-field');
    ctx = canvas.getContext('2d');

    var gameEngine = new GameEngine();
    gameEngine.initializeGameSettings();

    var loop;
    if (typeof loop !== "undefined") {
        clearInterval(loop);
    }
    else {
        loop = setInterval(gameEngine.startGame, 75);
    }
}