package com.example.calculator

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.Button
import android.widget.TextView
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*
import kotlin.math.log

class MainActivity : AppCompatActivity(),View.OnClickListener {

    lateinit var btn0 : Button
    lateinit var btn1 : Button
    lateinit var btn2 : Button
    lateinit var btn3 : Button
    lateinit var btn4 : Button
    lateinit var btn5 : Button
    lateinit var btn6 : Button
    lateinit var btn7 : Button
    lateinit var btn8 : Button
    lateinit var btn9 : Button
    lateinit var btnDot : Button
    lateinit var btnClear : Button
    lateinit var btnDiv : Button
    lateinit var btnMult : Button
    lateinit var btnMinus : Button
    lateinit var btnPlus : Button
    lateinit var btnRes : Button
    lateinit var textRes : TextView

    val calc = Clac()
    var check: Boolean = false

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        init()
    }


    fun init(){
        btn0 = findViewById(R.id.btn0)
        btn1 = findViewById(R.id.btn1)
        btn2 = findViewById(R.id.btn2)
        btn3 = findViewById(R.id.btn3)
        btn4 = findViewById(R.id.btn4)
        btn5 = findViewById(R.id.btn5)
        btn6 = findViewById(R.id.btn6)
        btn7 = findViewById(R.id.btn7)
        btn8 = findViewById(R.id.btn8)
        btn9 = findViewById(R.id.btn9)
        btnDot = findViewById(R.id.btnDot)
        btnClear = findViewById(R.id.btnClear)
        btnDiv = findViewById(R.id.btnDiv)
        btnRes = findViewById(R.id.btnRes)
        btnMult = findViewById(R.id.btnMult)
        btnPlus = findViewById(R.id.btnPlus)
        btnMinus = findViewById(R.id.btnMinus)
        textRes = findViewById(R.id.textRes)

        btn0.setOnClickListener(this)
        btn1.setOnClickListener(this)
        btn2.setOnClickListener(this)
        btn3.setOnClickListener(this)
        btn4.setOnClickListener(this)
        btn5.setOnClickListener(this)
        btn6.setOnClickListener(this)
        btn7.setOnClickListener(this)
        btn8.setOnClickListener(this)
        btn9.setOnClickListener(this)
        btnDot.setOnClickListener(this)
        btnRes.setOnClickListener(this)
        btnClear.setOnClickListener(this)
        btnDiv.setOnClickListener(this)
        btnMult.setOnClickListener(this)
        btnPlus.setOnClickListener(this)
        btnMinus.setOnClickListener(this)
    }

    override fun onClick(v: View?) {
        var temp: String = textRes.text.toString()
        when(v){
            btn0->{
                calc.getNumber(0,check)
                textRes.text = temp + "0"
            }
            btn1->{
                calc.getNumber(1,check)
                textRes.text = temp + "1"
            }
            btn2->{
                calc.getNumber(2,check)
                textRes.text = temp + "2"
            }
            btn3->{
                calc.getNumber(3,check)
                textRes.text = temp + "3"
            }
            btn4->{
                calc.getNumber(4,check)
                textRes.text = temp + "4"
            }
            btn5->{
                calc.getNumber(5,check)
                textRes.text = temp + "5"
            }
            btn6->{
                calc.getNumber(6,check)
                textRes.text = temp + "6"
            }
            btn7->{
                calc.getNumber(7,check)
                textRes.text = temp + "7"
            }
            btn8->{
                calc.getNumber(8,check)
                textRes.text = temp + "8"
            }
            btn9->{
                calc.getNumber(9,check)
                textRes.text = temp + "9"
            }
            btnDot->{
                calc.getNumber(".",check)
                textRes.text = temp + "."
            }
            btnClear->{
                calc.clear()
                textRes.text=""
                check=false
            }
            btnDiv->{
                calc.getOperat("÷")
                check=true
                textRes.text=""
            }
            btnMinus->{
                calc.getOperat("-")
                check=true
                textRes.text=""
            }
            btnPlus->{
                calc.getOperat("+")
                check=true
                textRes.text=""
            }
            btnMult->{
                calc.getOperat("×")
                check=true
                textRes.text=""
            }
            btnRes->{
                textRes.text = calc.showRes().toString()
                if(textRes.text != "Cannot Div By Zero")
                    calc.getNumber(calc.showRes())
                else{
                    calc.clear()
                    check=false
                }
            }
        }
    }
}
