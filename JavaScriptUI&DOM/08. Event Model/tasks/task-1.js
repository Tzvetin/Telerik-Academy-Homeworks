/* globals $ */

/* 

Create a function that takes an id or DOM element and:

- If an id is provided, select the element
- Finds all elements with class button or content within the provided element
    Change the content of all .button elements with "hide"
- When a .button is clicked:
    Find the topmost .content element, that is before another .button and:
      a. If the .content is visible:
        - Hide the .content
        - Change the content of the .button to "show"
      b. If the .content is hidden:
        - Show the .content
        - Change the content of the .button to "hide"
      c. If there isn't a .content element after the clicked .button and before other .button, do nothing
- Throws if:
    The provided DOM element is non-existent
    The id is either not a string or does not select any DOM element

*/

function solve(){
  return function (selector) {
    var domElement,
        buttons,
        i,
        len,
        next;

    if (!selector) {
      throw new Error();
    }
    if ((!(typeof(selector) === 'string')) && (!(selector instanceof HTMLElement))) {
      throw new Error();
    }
    domElement = document.getElementById(selector);
    if (domElement === null) {
      throw new Error();
    }

    buttons = document.getElementsByClassName('button');

    for (i = 0, len = buttons.length; i < len; i += 1) {
      buttons[i].innerHTML = "hide";

      buttons[i].addEventListener('click', function(){
        next = this.nextElementSibling;

          while (next.className !== 'button') {
              if (next.className === 'content') {
                  break;
              }
              next = next.nextElementSibling;
          }

          if (next.className === 'content' && next.style.display === '') {
              this.innerHTML = 'show';
              next.style.display = 'none';
          }
          else if (next.className === 'content' && next.style.display === 'none') {
              this.innerHTML = 'hide';
              next.style.display = '';
          }

      }, false);
    }

  };
};

module.exports = solve;