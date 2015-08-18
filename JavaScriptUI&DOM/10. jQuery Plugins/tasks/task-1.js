function solve(){
  return function(selector){
      var $selector,
          options,
          $dropdownContainer,
          $currentSelection,
          $optionsContainer,
          i,
          len;

      $selector = $(selector)
          .css('display','none');

      $dropdownContainer = $('<div />')
          .addClass('dropdown-list');

      $currentSelection = $('<div />')
          .addClass('current')
          .text('Select a value');

      $optionsContainer = $('<div />')
          .addClass('options-container')
          .css('display','none');

      options = $selector.find('option');

      for (i = 0, len = options.length; i < len; i += 1) {
          var newItem = $('<div />')
              .addClass('dropdown-item')
              .attr('data-value', $(options[i]).val())
              //.attr('data-index', i)
              .text($(options[i]).text());
          $optionsContainer.append(newItem);
      }

      $dropdownContainer.append($selector);
      $dropdownContainer.append($currentSelection);
      $dropdownContainer.append($optionsContainer);

      $('body').append($dropdownContainer);

      $('.current').on('click', function() {
          if ($optionsContainer.css('display') === 'none') {
              $optionsContainer.css('display', '');
              $('.current').text('Select a value');
          }
          else{
              $optionsContainer.css('display', 'none');
          }
      });

      $('.dropdown-item').on('click', function() {
          var $this = $(this);
          $('.current').attr('data-value', $this.attr('data-value'));
          $('.current').text($this.text());
          $optionsContainer.css('display','none');
          $selector.val($this.attr('data-value'));
          $selector.attr('value', $selector.val());
      });
  };
}

module.exports = solve;