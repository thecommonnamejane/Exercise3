package com.example.exercise3

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        getPremium()
    }

    fun getPremium():Double{
        val premium : Double

        premium = when(spinnerAge.selectedItemPosition){
            0 -> { 60.0}
            1 -> { 70.0 +
                    (if(radioButtonMale.isChecked()) 50.0 else 0.0) +
                    (if(checkBoxSmoker.isChecked) 100.0 else 0.0)
            }
            2 -> { 90.0 +
                    (if (radioButtonMale.isChecked()) 100.0 else 0.0) +
                    (if(checkBoxSmoker.isChecked) 150.0 else 0.0)
            }
            3 -> { 120.0 +
                    (if(radioButtonMale.isChecked()) 150.0 else 0.0) +
                    (if(checkBoxSmoker.isChecked) 200.0 else 0.0)
            }
            4 -> { 150.0 +
                    (if(radioButtonMale.isChecked()) 200.0 else 0.0) +
                    (if(checkBoxSmoker.isChecked) 250.0 else 0.0)
            }
            else -> { 150.0 +
                    (if(radioButtonMale.isChecked()) 200.0 else 0.0) +
                    (if(checkBoxSmoker.isChecked) 300.0 else 0.0)
            }
        }
        return premium

    }
}
