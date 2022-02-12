var regExp = /(\w)+/g;
var nueronArray = [];
var valueArray = [];
var processItems = []
var newProcessedItems = [];
var newValueArray = [];

function count() {
for(var loop in processItems) {
    var id = processItems[loop];
    var nueron = nueronArray[id];
    nueron = nueron.Match(regExp);
    var value = valueArray[id] * 2;
    for(var doCount in nueron) {
        value = value / 2;
    newProcessedItems.push(nueron[count]);
    newValueArray.push(value);
  }
}
}
function start(time) {
var timer1 = setInterval(count, time);
}
document.getElementById("start").addEventListener("click", start(100));