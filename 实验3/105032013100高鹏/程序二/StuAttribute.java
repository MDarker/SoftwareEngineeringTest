package stuFunc;

/**
 *ѧ������ϵͳ��ѧ�����˻�����Ϣ��
 * @author f
 * 
 */

public class StuAttribute {
	String stuName;//ѧ������
	String stuNo;//ѧ��ѧ��
	String stuGender;//ѧ���Ա�
	String stuClass;//ѧ���༶
	String stuGrade;//ѧ���꼶
	
	//���캯��
	public StuAttribute(String stuName, String stuNo, String stuGender, String stuClass, String stuGrade) {
		super();
		this.stuName = stuName;
		this.stuNo = stuNo;
		this.stuGender = stuGender;
		this.stuClass = stuClass;
		this.stuGrade = stuGrade;
	}
	
	public String getStuName() {
		return stuName;
	}
	
	public String getStuNo() {
		return stuNo;
	}
	
	public String getStuGender() {
		return stuGender;
	}
	
	public String getStuClass() {
		return stuClass;
	}
	
	public String getStuGrade() {
		return stuGrade;
	}
}
