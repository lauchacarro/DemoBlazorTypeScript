namespace ParagraphTag {
    class ParagraphTagFunctions {
        public setInnerHtml(element: HTMLParagraphElement, innerHtml: string): void {
            element.innerText = innerHtml;
        }
    }

    export function Load() {
        window["ParagraphTagFunctions"] = new ParagraphTagFunctions();
    }
}

ParagraphTag.Load();