/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  ok* The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  ok* Any of the contents is neither `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
    var domElement,
        i,
        len,
        div,
        documentFragment,
        currentDiv;

    if (!element){
      throw new Error();
    }

    if ((!(typeof(element) === 'string')) && (!(element instanceof HTMLElement))) {
      throw new Error();
    }

    if (typeof(element) === 'string') {
      domElement = document.getElementById(element);
    }
    else {
      domElement = element;
    }

    if (domElement === 'null'){
      throw new Error();
    }

    if (!contents || contents === 'undefined') {
      throw new Error();
    }

    for (i = 0, len = contents.length; i < len; i += 1) {
      if (!(typeof(contents[i]) === 'string') && (!(typeof(contents[i]) === 'number'))) {
        throw new Error();
      }
    }

    domElement.innerHTML = "";

    div = document.createElement('div');
    documentFragment = document.createDocumentFragment();

    for (i = 0, len = contents.length; i < len; i += 1) {
      currentDiv = div.cloneNode(true);
      currentDiv.innerHTML = contents[i];
      documentFragment.appendChild(currentDiv);
    }

    domElement.appendChild(documentFragment);
  };
};