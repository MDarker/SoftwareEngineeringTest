package stuFunc;

/**
 *学生管理系统的学生个人基本信息类
 * @author f
 * 
 */

public class StuAttribute {
	String stuName;//学生姓名
	String stuNo;//学生学号
	String stuGender;//学生性别
	String stuClass;//学生班级
	String stuGrade;//学生年级
	
	//构造函数
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
