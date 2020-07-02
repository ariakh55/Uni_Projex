fun ageGroup(x: Int): String{
    if (x>1 && x<=6)
        return "Infant"
    else if (x>6 && x<=11)
        return "Kid"
    else if (x>11 && x<=18)
        return "Teenager"
    else
        return "Adult"
}

fun main(){
    println("Enter age to determine age group😊")
    var opt = readLine()!!.toInt()
    println(ageGroup(opt))
}