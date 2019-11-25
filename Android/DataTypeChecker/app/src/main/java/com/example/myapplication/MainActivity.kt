package com.example.myapplication

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.service.autofill.OnClickAction
import android.util.Log
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.Toast

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        check(12.12f)
        check(8965562312345)
        check(212.12551)
        check(false)
        check("Hello")
        check(583)
        var byte: Byte = 12
        check(byte)
    }

    fun logMsg(msg:String){
        Log.e("Kotlin--logMsg",msg)
    }

    fun check(obj:Any){
        when(obj){
            is Byte -> logMsg("$obj is Byte")
            is Int -> logMsg("$obj is INT")
            is Float -> logMsg("$obj is FLOAT")
            is Long -> logMsg("$obj is LONG")
            is String -> logMsg("$obj is STRING")
            is Boolean -> logMsg("$obj is BOOL")
            is Double -> logMsg("$obj is DOUBLE")
            else -> logMsg("IDK what the hell is this!!")
        }
    }
}
