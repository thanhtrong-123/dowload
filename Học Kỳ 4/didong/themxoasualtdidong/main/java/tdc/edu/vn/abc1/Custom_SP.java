package tdc.edu.vn.abc1;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;

public class Custom_SP extends ArrayAdapter {
    Context context;
    int resource;
    ArrayList<SanPham>data;
    public Custom_SP(Context context, int resource, ArrayList<SanPham>data) {
        super(context, resource, data);
        this.context=context;
        this.resource=resource;
        this.data=data;
    }

    @Override
    public View getView(final int position, View convertView, ViewGroup parent) {
        convertView= LayoutInflater.from(context).inflate(resource,null );
        TextView tvTen=convertView.findViewById(R.id.tvten);
        TextView tvSL=convertView.findViewById(R.id.tvsl);
        TextView btnCT=convertView.findViewById(R.id.btnCT);
        final SanPham sp=data.get(position);
        tvTen.setText(sp.getTen());
        tvSL.setText(sp.getSl());
        btnCT.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent=new Intent(context,Main_ChiTiet.class);
                intent.putExtra("sp", sp);
                intent.putExtra("index",position);
                context.startActivity(intent);
            }
        });
        return convertView;
    }
}
