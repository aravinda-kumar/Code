package zhushuai.oop01;

public class Base {
	
	public Base(String name, int age, int height, char sex) {
		// TODO Auto-generated constructor stub
		this.name = name;
		this.age = age;
		this.height = height;
		this.sex = sex;
	}
	
	private String name;	//���пɼ�������λ�ò��ɼ�
	int age;				//���пɼ��������пɼ�
	protected int height;	//���пɼ���������������ɼ�
	public char sex;		//����λ�ö��ɼ�
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return name + " " + age + " " + height  + " " + sex;
	}
	
}
