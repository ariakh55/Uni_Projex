var flag = true

fun operation(a: Int, b: Int, opt: Int): Int{
    when(opt) {
        1->{
            return a+b;
        }
        2->{
            return a-b;
        }
        3->{
            return a*b;
        }
        4->{
            if(b==0){
                println("Cannot Div by 0")
                return 0
            }
            return a/b;
        }
        else -> {
            flag = false
            return 0
            }
    }
}

fun main(){
    
    var opt: Int
    while(flag){
        println("\n\n======Calculator======")
        println("1 -> +")
        println("2 -> -")
        println("3 -> *")
        println("4 -> /")
        println("======================")
        println("Choice: ")
        opt = readLine()!!.toInt()
        println("\n\nEnter first number: ")
        var a = readLine()!!.toInt()
        println("Enter second number: ")
        var b = readLine()!!.toInt()
        println("Resualt: "+ operation(a,b,opt))
    }
}