package myLinkedList;

/**
 * 自定义hashmap
 * @author zhushuai
 *
 */
public class MyHashMap01 {
	Node2[] table;	//位桶数组，bucket array
	int size;
	
	public MyHashMap01() {
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
	}
	
	public static void main(String[] args) {
		MyHashMap01 hm = new MyHashMap01();
		hm.put(85, "aa");
		hm.put(69, "bb");
		hm.put(53, "cc");
 
	}
	
	public int myHash(int v, int length) {
		System.out.println("hash in myHash:" + (v&(length-1)));
		return v&(length-1);
	}
}







