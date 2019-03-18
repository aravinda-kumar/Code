package zhushuai.oop;


public class TestEquals {
	public static void main(String[] args) {
		UserNew u1 = new UserNew(1000, "asd", "123445");
		UserNew u2 = new UserNew(1000, "asd", "123445");
		
		System.out.println(u1 == u2);
		System.out.println(u1.equals(u2));
	}
}

class UserNew{
	int id;
	String name;
	String pwd;
	
	public UserNew(int id, String name, String pwd) {
		super();
		this.id = id;
		this.name = name;
		this.pwd = pwd;
	}
	
	@Override
	public boolean equals(Object obj) {
		// TODO Auto-generated method stub
		UserNew tmpNew = (UserNew)obj;
		return tmpNew.id == this.id;
	}
}