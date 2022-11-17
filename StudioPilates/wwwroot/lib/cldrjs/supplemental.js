import Cldr from "./core";
import supplementalMain from "./supplemental/main";

var initSuper = Cldr.prototype.init;

/**
 * .init() automatically ran on construction.
 *
 * Overload .init().
 */
Cldr.prototype.init = function () {
    initSuper.apply(this, arguments);
    this.supplemental = supplementalMain(this);
};

export default Cldr;
