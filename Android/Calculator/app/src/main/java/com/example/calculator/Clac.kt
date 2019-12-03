package com.example.calculator

import android.util.Log

class Clac{
    protected  var fnumber: String = ""
    protected  var snumber: String = ""
    protected var res: Int = 0
    protected  var operation: String = ""

    fun getNumber(n: Any){
        Log.e("---Calc---","$n is the saved number")
        fnumber = n.toString()
    }

    fun getNumber(n: Any, flag: Boolean){
        if(flag){
            Log.e("---Calc---","$n is Second")
            snumber += n.toString()
        }
        else {
            Log.e("---Calc---", "$n is First")
            fnumber += n.toString()
        }
    }

    fun getOperat(op: String){
        Log.e("---Clac---",op)
        operation = op
    }

    fun showRes(): Any{
        var err = false
        var fno = fnumber.toInt()
        var sno = snumber.toInt()
        when(operation){
            "+"->{
                res = fno + sno
            }
            "-"->{
                res = fno - sno
            }
            "÷"->{
                if(sno!=0)
                    res = fno / sno
                else
                    err = true
            }
            "×"->{
                res = fno * sno
            }
        }
        if (err)
            return "Cannot Div By Zero"
        else
            return res
    }

    fun clear(){
        Log.e("---Clac---","Clear")
        res = 0
        fnumber = ""
        snumber = ""
        operation = ""
    }
}
