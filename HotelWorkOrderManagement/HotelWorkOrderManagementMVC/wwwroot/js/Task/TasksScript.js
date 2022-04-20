class ClickAndHold {
    /**
     * @param {EventTarget} target The HTML element to apply the event to
     * @param {Function} callback The function to run once the target is clicked and held
     * */

    constructor(target, callback) {
        this.target = target;
        this.callback = callback;
        this.isHeld = false;
        this.activeHoldTimeoutId = null;

        ["mousedown", "touchstart"].forEach(type => {
            this.target.addEventListener(type, this._onHoldStart.bind(this));
        });

        ["mouseup","mouseleave","mouseout", "touchend","touchcancel"].forEach(type => {
            this.target.addEventListener(type, this._onHoldEnd.bind(this));
        });
    }

    _onHoldStart() {
        this.isHeld = true;

        this.activeHoldTimeoutId = setTimeout(() => {
            this.activeHoldTimeoutId = setTimeout(() => {
                if (this.isHeld) {
                    this.callback();
                }
            })
        },1000)
    }

    _onHoldEnd() {
        this.isHeld = false;
        clearTimeout(this.activeHoldTimeoutId);
    }

    /**
     * @param {EventTarget} target The HTML element to apply the event to
     * @param {Function} callback The function to run once the target is clicked and held
     * */

    static apply(target, callback) {
        new ClickAndHold(target,callback)
    }
}

const clickableDiv = document.getElementById("clickableDiv");
ClickAndHold.apply(myButton, () => {
    alert("Click and hold!")
})


