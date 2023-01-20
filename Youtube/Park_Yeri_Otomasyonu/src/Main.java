import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Stack;

import javax.swing.*;

class Node{
	String data;
	Node next;
	Node(String data){
		this.data=data;
		next=null;
	}
}
class list{
	Node head,tail;
	int size,count;
	
	list(int size){
		this.size=size;
		head=tail=null;
		count=0;
	}
	
	//add node to list
	void add(String data) {
		if (!isFully()) {
			Node new_node=new Node(data);
			if(head==null) {
				head=new_node;
				tail=new_node;
				count++;
			}
			else {
				tail.next=new_node;
				tail=new_node;
				count++;
			}
		}else System.out.println("boş park yeri bulunmamaktadır!");
	}
	void delete() {
		if (!isEmpty()) {
			Node temp=head,temp2=temp;
			while (temp.next!=null) {
				temp2=temp;
				temp=temp.next;
			}
			temp2.next=null;
		}else System.out.println("park yeri zaten boş!");
	}
	
	boolean isFully() {
		return size==count;
	}
	boolean isEmpty() {
		return count==0;
	}
}

class park_window extends JFrame{
	JPanel park_view;
	JTextField plaka;
	JButton[] parka=new JButton[10];
	int park_count=-1;
	list park_area=new list(10);
	park_window(){
		this.setTitle("DYPARKING");
		this.setSize(500,500);
		this.setLayout(null);
		
		plaka=new JTextField();
		plaka.setBounds(0,200,100,37);
		
		park_view=new JPanel();
		park_view.setBounds(0, 0, 500, 200);
		park_view.setBackground(Color.BLACK);
		park_view.setLayout(new GridLayout(0,2));
		
		for (int i = 0; i < parka.length; i++) {
			parka[i]=new JButton("Boş Yer");
		}
		
		
		
		for(JButton p:parka) {
				p.addActionListener(e -> {
						if(p.getText().contains("Boş Yer")) {
							p.setText(plaka.getText().toUpperCase());
							park_count++;
						}
						else {
							p.setText("Boş Yer");
							park_count--;
						}

						park_view.revalidate();
				});
				park_view.add(p);
		}
		add(plaka);
		add(park_view);
		this.setVisible(true);
	}
}


public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		park_window pw=new park_window();
	}
}
