class Graphics_Parameter {
    constructor(NamePlayer1, NamePlayer2, Line_Color, Line_Width, SizeBoard, ThemeBoard, ColorPlayer1, ColorPlayer2) {
        this.name1 = NamePlayer1;
        this.name2 = NamePlayer2;
        this.lc = Line_Color;
        this.lw = Line_Width;
        this.sizeboard = SizeBoard;
        this.themeboard = ThemeBoard;
        this.colorplayer1 = ColorPlayer1;
        this.colorplayer2 = ColorPlayer2;
        this.scale = 20;
    }
}
class Draw extends Graphics_Parameter {
    constructor(NamePlayer1, NamePlayer2, Line_Color, Line_Width, SizeBoard, ThemeBoard, ColorPlayer1, ColorPlayer2) {
        super(NamePlayer1, NamePlayer2, Line_Color, Line_Width, SizeBoard, ThemeBoard, ColorPlayer1, ColorPlayer2);
        this.linecolorFunc = function (boardCanvas) { boardCanvas.strokeStyle = this.lc; }
        this.thicknessFunc = function (boardCanvas) { boardCanvas.lineWidth = this.lw; }
        this.backgroundcolor = function () { return this.themeboard; }
        this.create_board = function (boardCanvas) {
            let x = 1, y = 1, LocationX, LocationY;
            while (x < this.sizeboard / this.scale) {
                LocationX = 20 * x;
                this.drawline(boardCanvas, LocationX, LocationX, 0, this.sizeboard);
                x++;
            }
            while (y < this.sizeboard / this.scale) {
                LocationY = 20 * y;
                this.drawline(boardCanvas, 0, this.sizeboard, LocationY, LocationY);
                y++;
            }
        }
        this.drawline = function (boardCanvas, sx, ex, sy, ey) {
            boardCanvas.beginPath();
            boardCanvas.moveTo(sx, sy);
            boardCanvas.lineTo(ex, ey);

            this.linecolorFunc(boardCanvas);
            this.thicknessFunc(boardCanvas);
            boardCanvas.stroke();
        }
    }
}

this.init = function () {
    const test2 = new Draw("x", "y", "#FF0000", 2, 400, "#0f0f0f", "x", "y");
    const canvas = document.getElementById("myCanvas");
    const boardCanvas = canvas.getContext("2d");
    test2.create_board(boardCanvas);
}