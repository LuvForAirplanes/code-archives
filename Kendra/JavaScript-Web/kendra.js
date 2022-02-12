var regExp = /(\w)+/g;
//Core Processor
//imports nuerons with AJAX
//imports nodes with AJAX
function nodeImport() {
    var request = new XMLHttpRequest();
    request.open("GET", "file://C:\Users\Micah\Documents\Kendra\JavaScript-Web\node.txt");
    request.send(null);
    return request.responseText;
}
//var nodeArray = nodeImport();
var nodeArray = ["1", "3"];
var processItems = [];
var valueArray = [];
var newProcessedItems = [];
var newValueArray = [];

var timer1;
var check;

function write(text) {
    document.getElementById("output").value += text + "\n";
}
function count() {
    if (check == true && processItems.length == 0) {
        clearInterval(timer1);
    }
    write("Entering count()");
    write(processItems.length);
    write("Item(s) to be processed: " + processItems.length);
    for (var loop in processItems) {
        var id = processItems[loop];
        var node = nodeArray[id];
        write("id: " + id + "; " + "item" + loop + ": " + node);
        node = node.match(regExp);
        var value = valueArray[id] * 2;
        for (var doCount in node) {
            value = Math.floor(value / 2);
            if (value > 100) {
                value = value + 100;
                if (node[doCount] == 1 && value > 100) {
                    write("Node 3 was reached and activated");
                    outText(1);
                }
                write(doCount);
                //nerve endings go here
                newProcessedItems.push(node[doCount]);
                newValueArray.push(value);
            }
        }
    }
processItems = newProcessedItems;
write(processItems);
    valueArray = newValueArray;
    write(valueArray);
newProcessedItems = [];
newValueArray = [];
}
function start(time) {
    var lineRegExp = /((\w)+)+\n/g;
    timer1 = setInterval(count, time);
    write("Timer was set for " + time + " milliseconds");
    processItems.concat(document.getElementById("startNueron").value.match(regExp));
    valueArray.concat(document.getElementById("startValue").value.match(regExp));
    nodeArray = document.getElementById("nodes").value.match(lineRegExp);
}
function getTime() {
    check = document.getElementById("test-tf").checked;
    var tt = parseInt(document.getElementById("timeInput").value);
    if (tt == null) {
        alert("No milleseconds were speciified");
    } 
    start(tt);
}