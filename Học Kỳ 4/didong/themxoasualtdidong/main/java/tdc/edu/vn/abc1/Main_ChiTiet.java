package tdc.edu.vn.abc1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import java.lang.reflect.Array;
import java.util.ArrayList;

public class Main_ChiTiet extends AppCompatActivity {
    int index=-1;
    EditText edtTen, edtSL;
    Custom_SP cus;
    Button btnRe, btnEdit,btnQL;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main__chi_tiet);
        setControl();
        setEvent();
    }

    private void setEvent() {

        SanPham sp= (SanPham) getIntent().getSerializableExtra("sp");
        edtTen.setText(sp.getTen());
        edtSL.setText(sp.getSl());
        btnQL.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
        btnRe.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int index= getIntent().getIntExtra("index",-1);
                MainActivity.data.remove(index);
                onBackPressed();
            }
        });
        btnEdit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int index= getIntent().getIntExtra("index",-1);
                MainActivity.data.set(index,new SanPham(edtTen.getText().toString(),edtSL.getText().toString()));
                onBackPressed();
            }
        });
    }

    private void setControl() {
        edtTen = findViewById(R.id.edtTenSP);
        edtSL = findViewById(R.id.edtSoLuong);
        btnRe=findViewById(R.id.btnXoa);
        btnEdit=findViewById(R.id.btnSua);
        btnQL=findViewById(R.id.btnQL);
    }
}
