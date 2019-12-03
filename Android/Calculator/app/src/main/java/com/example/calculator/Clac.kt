package com.example.calculator

import android.util.Log

class Clac{
    protected  var fnumber: String = ""
    protected  var snumber: String = ""
    protected  var res: Float = 0f
    protected  var operation: String = ""

    fun getNumber(n: Any){
        Log.e("---Clac---","$n")
    }

    fun getOperat(op: String){
        Log.e("---Clac---",op)
    }

    fun showRes(){
        Log.e("---Clac---","Result")
    }

    fun clear(){
        Log.e("---Clac---","Clear")
    }
}
