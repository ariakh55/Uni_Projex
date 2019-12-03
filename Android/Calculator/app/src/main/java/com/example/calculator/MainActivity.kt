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
    lateinit var btnPlusMinus : Button
    lateinit var btnClear : Button
    lateinit var btnPtn : Button
    lateinit var btnPer : Button
    lateinit var btnDiv : Button
    lateinit var btnMult : Button
    lateinit var btnMinus : Button
    lateinit var btnPlus : Button
    lateinit var btnRes : Button
    lateinit var textRes : TextView


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
        btnPlusMinus = findViewById(R.id.btnPlusMinus)
        btnClear = findViewById(R.id.btnClear)
        btnPtn = findViewById(R.id.btnPtn)
        btnPer = findViewById(R.id.btnPercent)
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
        btnPlusMinus.setOnClickListener(this)
        btnClear.setOnClickListener(this)
        btnPtn.setOnClickListener(this)
        btnPer.setOnClickListener(this)
        btnDiv.setOnClickListener(this)
        btnMult.setOnClickListener(this)
        btnPlus.setOnClickListener(this)
        btnMinus.setOnClickListener(this)
    }

    override fun onClick(v: View?) {
        /*when(v){
            btn0->{}
            btn1->{}
            btn2->{}
            btn3->{}
            btn4->{}
            btn5->{}
            btn6->{}
            btn7->{}
            btn8->{}
            btn9->{}
            btnDot->{}
            btnPlusMinus->{}
            btnClear->{}
            btnPtn->{}
            btnPer->{}
            btnDiv->{}
            btnMinus->{}
            btnPlus->{}
            btnMult->{}
            btnRes->{}
        //Don't Pay Attention!! It is not completed yet
        }*/
    }
}
