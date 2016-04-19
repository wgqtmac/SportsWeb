var ggRoll = {
    roll: document.getElementById("roll"),
    speed: 20,
    statusX: 1,
    statusY: 1,
    x: 100,
    y: 300,
    winW: document.documentElement.clientWidth - document.getElementById("roll").offsetWidth,
    winH: document.documentElement.clientHeight - document.getElementById("roll").offsetHeight,
    Go: function () {
        this.roll.style.left = this.x + 'px';
        this.roll.style.top = this.y + 'px';

        this.x = this.x + (this.statusX ? -1 : 1)
        if (this.x < 0) { this.statusX = 0 }
        if (this.x > this.winW) { this.statusX = 1 }

        this.y = this.y + (this.statusY ? -1 : 1)
        if (this.y < 0) { this.statusY = 0 }
        if (this.y > this.winH) { this.statusY = 1 }
    }
}
var interval = setInterval("ggRoll.Go()", ggRoll.speed);
ggRoll.roll.onmouseover = function () { clearInterval(interval) };
ggRoll.roll.onmouseout = function () { interval = setInterval("ggRoll.Go()", ggRoll.speed) };