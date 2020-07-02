fun numToText (x: Any?):String?{
    if(x !is Int){
        println("Invalid data type")
        return null
    }
    when(x){
        2 -> return "two"
        3 -> return "three"
        4 -> return "four"
        5 -> return "five"

        else -> return "other"
    }
}

fun main(){
    println("Enter your desired number:")
    var opt = readLine()!!.toInt();
    print(numToText(opt))
}