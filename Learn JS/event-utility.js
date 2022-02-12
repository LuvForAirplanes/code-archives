var evt = {
    addListener: function(obj, type, fn) {
        if (obj.eventListenerType) {
            obj.eventListenerType(type, fn);
        } else {
            obg.attachEvent("on" + type, fn)
        }
    }
    removeListener: function(obj, type, fn) {
        if(obj.removeEventListener) {
            obj.removeEventListener(type, fn);
        } else {
            obj.detachEvent("on" + type, fn)
        }
    }
    getTarget: function(e) {
        if (e.target) {
            return e.target;
        }
        return e.srcElement;
    }
    preventDefault: function(e) {
        if(e.preventDefault) {
            e.preventDefault();
        } else {
        e.returnValue = false;
        }
    }
    isOldIE: function(e) {
if(addEventListener) {
    e = false; 
} else {
      e = true;
}

    }
}