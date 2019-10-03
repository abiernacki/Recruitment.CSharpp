function fixage(tab) {

    var tmpTab = [];
    var i = 0;

    for (i = 0; i < tab.length; i++) {
        if (tab[i] >= 18 && tab[i] <= 60) {
            tmpTab[i] = tab[i];
        }
    }

    var tmp = [];
    var counter = 0;
    var j = 0;
    for (j = 0; j < tmpTab.length; j++) {
        if (tmpTab[j] !== 0) {
            tmp[j] = tmpTab[j];
            counter++;
        }
    }

    var k = 0;
    for (k = 0 ; k < tmp.length; k++) {
        if (tmp[k] === undefined) {
            tmp.splice(k,1);
        }
    }
    tmp.splice(0,1);


    if (counter === 0){
        return "NA";


    }

    return tmp;

}