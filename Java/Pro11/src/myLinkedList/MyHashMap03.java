package myLinkedList;

/**
 * 自定义hashmap
 * @author zhushuai
 * 实现tostring()查看信息
 */
public class MyHashMap03 {
	Node2[] table;	//位桶数组，bucket array
	int size;
	
	public MyHashMap03() {
		// TODO Auto-generated constructor stub
		table = new Node2[16];	//长度一定是2的整数次幂
	}
	
	public void put(Object key, Object value) {
		//生成一个节点
		Node2 newNode2 = new Node2();
		newNode2.hash = myHash(key.hashCode(), table.length);
		newNode2.key = key;
		newNode2.value = value;
		newNode2.next = null;
		
		Node2 preNode = null;
		
		if(table[newNode2.hash] == null) {
			//此时数组内为空，直接将新节点放入
			table[newNode2.hash] = newNode2;
		}else {
			//如果不为空，遍历链表，找到合适的位置
//			System.out.println("==============");
			Node2 temp = table[newNode2.hash];
			while(temp != null) {
				//判断Key是否重复
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
		
		//先遍历整个数组查找头节点
		for(int i=0;i<table.length;i++) {
			temp = table[i];
			//判断数组当前位置是否为空
			if(temp == null) {
				continue;
			}
			//对于不为空的位置开始遍历整个链表
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







