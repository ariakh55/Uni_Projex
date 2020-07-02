fun dayOfWeek (x: Int): String{
    when (x){
        0 -> return "Saturday"
        1 -> return "Sunday"
        2 -> return "Monday"
        3 -> return "Tuesday"
        4 -> return "Wednesday"
        5 -> return "Thursday"
        6 -> return "Friday"
        
        else -> return "Error 44310 - Invalid number!"
    }
}

fun main(){
    println("Enter number to see what day it is: [ 0 - 6 ]")
    var opt = readLine()!!.toInt()
    println(dayOfWeek(opt));
}