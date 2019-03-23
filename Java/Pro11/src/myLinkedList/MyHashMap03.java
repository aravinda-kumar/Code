package myLinkedList;

/**
 * �Զ���hashmap
 * @author zhushuai
 * ʵ��tostring()�鿴��Ϣ
 */
public class MyHashMap03 {
	Node2[] table;	//λͰ���飬bucket array
	int size;
	
	public MyHashMap03() {
		// TODO Auto-generated constructor stub
		table = new Node2[16];	//����һ����2����������
	}
	
	public void put(Object key, Object value) {
		//����һ���ڵ�
		Node2 newNode2 = new Node2();
		newNode2.hash = myHash(key.hashCode(), table.length);
		newNode2.key = key;
		newNode2.value = value;
		newNode2.next = null;
		
		Node2 preNode = null;
		
		if(table[newNode2.hash] == null) {
			//��ʱ������Ϊ�գ�ֱ�ӽ��½ڵ����
			table[newNode2.hash] = newNode2;
		}else {
			//�����Ϊ�գ����������ҵ����ʵ�λ��
//			System.out.println("==============");
			Node2 temp = table[newNode2.hash];
			while(temp != null) {
				//�ж�Key�Ƿ��ظ�
//				System.out.println("++++++++++++++++++");
				if(newNode2.key.equals(temp.key)){
//					System.out.println("==============");
					temp.value = newNode2.value;
					return;
				}
				preNode = temp;
				temp = temp.next;
			}
			preNode.next = newNode2;
		}
		size++;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		StringBuilder sb = new StringBuilder();
		sb.append('{');
		
		Node2 temp = null;
		
		//�ȱ��������������ͷ�ڵ�
		for(int i=0;i<table.length;i++) {
			temp = table[i];
			//�ж����鵱ǰλ���Ƿ�Ϊ��
			if(temp == null) {
				continue;
			}
			//���ڲ�Ϊ�յ�λ�ÿ�ʼ������������
			while(temp != null) {
				sb.append(temp.key + ":" + temp.value + " ");
				temp = temp.next;
			}
		}
		if(sb.length() == 1) {
			sb.append('}');
		}else {
			sb.setCharAt(sb.length()-1, '}');			
		}
		return sb.toString();
	}
	
	public static void main(String[] args) {
		MyHashMap03 hm = new MyHashMap03();
		hm.put(85, "aa");
		hm.put(69, "bb");
		hm.put(53, "cc");
		
		System.out.println(hm);
	}
	
	public int myHash(int v, int length) {
		System.out.println("hash in myHash:" + (v&(length-1)));
		return v&(length-1);
	}
}







