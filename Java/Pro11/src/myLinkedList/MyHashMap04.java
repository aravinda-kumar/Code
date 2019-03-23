package myLinkedList;

/**
 * �Զ���hashmap
 * @author zhushuai
 * ʵ��tostring()�鿴��Ϣ
 */
public class MyHashMap04<K,V> {
	Node3<K,V> [] table;	//λͰ���飬bucket array
	int size;
	
	public MyHashMap04() {
		// TODO Auto-generated constructor stub
		table = (Node3<K,V>[])new Node3 [16];	//����һ����2����������
	}
	
	public void put(K key, V value) {
		//����һ���ڵ�
		Node3<K,V> newNode3 = new Node3<K,V> ();
		newNode3.hash = myHash(key.hashCode(), table.length);
		newNode3.key = key;
		newNode3.value = value;
		newNode3.next = null;
		
		Node3<K,V>  preNode = null;
		
		if(table[newNode3.hash] == null) {
			//��ʱ������Ϊ�գ�ֱ�ӽ��½ڵ����
			table[newNode3.hash] = newNode3;
		}else {
			//�����Ϊ�գ����������ҵ����ʵ�λ��
//			System.out.println("==============");
			Node3<K,V>  temp = table[newNode3.hash];
			while(temp != null) {
				//�ж�Key�Ƿ��ظ�
//				System.out.println("++++++++++++++++++");
				if(newNode3.key.equals(temp.key)){
//					System.out.println("==============");
					temp.value = newNode3.value;
					return;
				}
				preNode = temp;
				temp = temp.next;
			}
			preNode.next = newNode3;
		}
		size++;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		StringBuilder sb = new StringBuilder();
		sb.append('{');
		
		Node3<K, V> temp = null;
		
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
		MyHashMap04<Integer, String> hm = new MyHashMap04<Integer, String>();
		hm.put(85, "aa");
		hm.put(69, "bb");
		hm.put(53, "cc");
		
		System.out.println(hm);
	}
	
	public int myHash(int v, int length) {
		//System.out.println("hash in myHash:" + (v&(length-1)));
		return v&(length-1);
	}
}







