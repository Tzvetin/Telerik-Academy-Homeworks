function solve(){
  return function(){
    $.fn.listview = function(data){
        var $this = $(this);
        var templateSelector = '#' + $this.attr('data-template');
        var templateHtml = $(templateSelector).html();
        var template = handlebars.compile(templateHtml);

        for (var i = 0, len = data.length; i < len; i += 1) {
            $this.append(template(data[i]));
        }

        return this;
    };
  };
}

module.exports = solve;