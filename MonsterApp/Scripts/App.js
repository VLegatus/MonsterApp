//null check
var App = App || {};

function sortTable(x) {
    //If x is 0, column is Name. If x is 1, column is Type.
    var table, rows, switching, i, monProp1, monProp2, dir, shouldswitch, switchcount = 0;
    table = document.getElementById("monsterTable");
    switching = true;
    dir = "desc";
    
    while (switching) {
        switching = false;
        rows = table.rows;
        var monsterTableCompare = document.getElementsByClassName("MonsterTableName");

        //alert(mtn.length)

        for (i = 0; i < (monsterTableCompare.length); i++) {

            //alert(monsterTableCompare[i].innerHTML);
            monProp1 = monsterTableCompare[i];
            monProp2 = monsterTableCompare[i + 1];
            if (dir == "asc") {
                if (monProp1.innerHTML.toLowerCase() > monProp2.innerHTML.toLowerCase()) {
                    shouldSwitch = true;
                }
            }
            else if (dir == "desc")
            {
                if (monProp1.innerHTML.toLowerCase() < monProp2.innerHTML.toLowerCase()) {
                    shouldSwitch = true;
                    //alert(i)
                    break;
                }
            }
        }
        if (shouldSwitch && i!= 0) {
            alert(monProp1.innerHTML)
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = false;
            switchcount++;
        } else {
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = false;
            }
        }
        //alert(switchcount); 
        //alert("loop check")
    }
    //alert("Check if whole thing runs")
}
