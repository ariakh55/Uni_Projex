package com.example.calculator

import android.util.Log
import android.widget.TextView
import org.w3c.dom.Text
import java.lang.NumberFormatException

class Clac{
    private var firstNumber = ""
    private var secondNumber = ""
    private var operation = ""
    private lateinit var result: TextView
    private  var claculated = false

    fun init_res(res: TextView){
        result = res
    }

    fun backspace(){
        if(operation==""){
            if(firstNumber.length>0) {
                firstNumber = firstNumber.substring(0, firstNumber.length - 1)
                result.text = "$firstNumber"
            }
        }else{
            if(secondNumber.length>0) {
                secondNumber = secondNumber.substring(0, secondNumber.length - 1)
                result.text = "$firstNumber$operation$secondNumber"
            }else if(secondNumber.length==0){
                secondNumber=""
                operation=""
                result.text="$firstNumber"
            }
        }
    }

    fun getNumber(number:String) {
        if (result == null) {
            Log.e("Calculator", "View is null")
            return
        }
        if (operation == "") {
            if (claculated) {
                firstNumber = ""
                result.text = ""
                if(firstNumber.length==0&&number==".")
                    return
                firstNumber += number
                claculated = false
            } else {
                if(firstNumber.length==0&&number==".")
                    return
                firstNumber += number
            }
            claculated = false
            Log.e("Calculator", "First number is $firstNumber")
        } else {
            if(secondNumber.length==0&&number==".")
                return
            secondNumber += number
            Log.e("Calculator", "Second number is $secondNumber")
        }
        result.append(number)
    }

    fun getOperator(op:String){
        if(result == null) {
            Log.e("MyCalculator", "View is null")
            return
        }
        if(firstNumber==""){
            Log.e("Calculator","First number is empty")
            return
        }
        if(operation == ""){
            operation=op
            result.append(op)
        }else{
            if(firstNumber!=""&&secondNumber!="")
                equal(op)
        }
    }

    fun equal(op:String = ""){
        if(result == null){
            Log.e("Calculator","View is null")
            return
        }
        if(firstNumber ==""||secondNumber==""||operation==""){
            return
        }
        try{
            var a:Double = firstNumber.toDouble()
            var b:Double = secondNumber.toDouble()
            var res = when(operation){
                "+" -> a+b
                "-" -> a-b
                "*" -> a*b
                "/" ->this.div(a,b)
                else -> 0.0
            }
            result.text="$res$op"
            firstNumber="$res"
            secondNumber=""
            operation = op
            claculated = true
        }catch (ex: NumberFormatException){
            Log.e("Calc","$ex")
        }

    }

    fun clear(){
        firstNumber = ""
        secondNumber = ""
        operation = ""
        result.text = ""
    }

    fun div(a:Double,b:Double):Double{
        if(b==0.0) return 0.0
        else return a/b
    }
}
