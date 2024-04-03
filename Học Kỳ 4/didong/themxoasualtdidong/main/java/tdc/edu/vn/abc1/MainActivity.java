package tdc.edu.vn.abc1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    int index=-1;
    EditText edtTen, edtSL;
    ListView lv;
    public static ArrayList<SanPham> data = new ArrayList<>();
    Custom_SP cus;
    Button btnAdd, btnRe, btnEdit,btnExit;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setControl();
        KhoiTao();
        setEvent();
    }

    private void setEvent() {
        cus = new Custom_SP(this, R.layout.layout_item, data);
        cus.notifyDataSetChanged();
        lv.setAdapter(cus);
        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                data.add(new SanPham(edtTen.getText().toString(),edtSL.getText().toString()));
                cus.notifyDataSetChanged();

            }
        });
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                index=position;
                edtTen.setText(data.get(position).getTen());
                edtSL.setText(data.get(position).getSl());
            }
        });
        btnRe.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                data.remove(index);
                cus.notifyDataSetChanged();
            }
        });
        btnEdit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                data.set(index,new SanPham(edtTen.getText().toString(),edtSL.getText().toString()));
                cus.notifyDataSetChanged();
            }
        });
        btnExit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();

            }
        });
    }

    private void KhoiTao() {
        data.add(new SanPham("iphone", "1"));
        data.add(new SanPham("xiaomi", "2"));
        data.add(new SanPham("nokia", "3"));
    }

    private void setControl() {
        edtTen = findViewById(R.id.edtTenSP);
        edtSL = findViewById(R.id.edtSoLuong);
        lv=findViewById(R.id.lvDanhSach);
        btnAdd=findViewById(R.id.btnThem);
        btnRe=findViewById(R.id.btnXoa);
        btnEdit=findViewById(R.id.btnSua);
        btnExit=findViewById(R.id.btnHienThi);
    }
}
