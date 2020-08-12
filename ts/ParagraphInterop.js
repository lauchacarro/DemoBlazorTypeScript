var ParagraphTag;
(function (ParagraphTag) {
    var ParagraphTagFunctions = /** @class */ (function () {
        function ParagraphTagFunctions() {
        }
        ParagraphTagFunctions.prototype.setInnerHtml = function (element, innerHtml) {
            element.innerText = innerHtml;
        };
        return ParagraphTagFunctions;
    }());
    function Load() {
        window["ParagraphTagFunctions"] = new ParagraphTagFunctions();
    }
    ParagraphTag.Load = Load;
})(ParagraphTag || (ParagraphTag = {}));
ParagraphTag.Load();
//# sourceMappingURL=ParagraphInterop.js.map