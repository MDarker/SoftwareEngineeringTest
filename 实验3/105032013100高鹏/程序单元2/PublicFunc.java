package publicFunc;
import java.util.*;

import stuFunc.StuAttribute;
import stuFunc.StuFunc;

/**
 *ѧ������ϵͳ�Ĺ�����
 * @author f
 * 
 */

//ѧ������ϵͳ�Ļ���������
public class PublicFunc {
	StuFunc stu = new StuFunc();//����һ��ѧ�����������
	Scanner input = new Scanner(System.in);//����һ�������ɨ����
	
	//���캯��
	public PublicFunc() {
		super();
		stu.ReadStuInfo();//�����ļ��е�����
	}

	//�˵���������
	public void ShowMenuTop (){
		System.out.println("-----------ѧ������ϵͳ----------");
	}

	//�ײ��˵�����
	public void ShowMenuFoot (){
		System.out.println("--------��ӭʹ��ѧ������ϵͳ--------------");
	}

	//�˵��б�
	public void ShowMainMenu (){
		System.out.println("\t1.��ʾ����ѧ����Ϣ\n");
		System.out.println("\t2.���ѧ����Ϣ\n");
		System.out.println("\t3.ɾ��ѧ����Ϣ\n");
		System.out.println("\t4.�޸�ѧ����Ϣ\n");
		System.out.println("\t5.��ѯѧ����Ϣ\n");
		System.out.println("\t6.����ѧ����Ϣ\n");
		System.out.println("\t7.�˳�ѧ������ϵͳ\n");
	}

	//�ر�ɨ����
	public void EndScanner(){
		input.close();
	}
	
	//ϵͳ������
	public void ShowMenuEnd (){
		System.out.println("-----------ллʹ��ѧ������ϵͳ--------------");
	}
	
	//�ظ�����ѡ��
	public boolean ConOp(){		
		while(true){
			try{
				System.out.println("��1�������� �����˳�");
				input.nextLine();
				String temp = input.nextLine();
				if(temp.compareTo("1") == 0)
				return true;//����true���ѭ������ѭ��
				return false;//����false���ѭ������ѭ���˳�����
			}catch(Exception e){
				return false;
			}
		}
	}
	
	//�������ѡ�񡪡������빦��
	public int FunNo(){
		try{
		System.out.println("�����������蹦�ܵ����");
		int i = input.nextInt();
		return i;//������Ӧ�Ĺ������
		}catch(Exception e){
			System.out.println("�����ʽ��������������");
			return -1;//���ط��������ѭ������ѭ��ִ��
		}
	}

	//����ѧ������
	public int StuNo(){
		try{
		System.out.println("������Ҫ¼���ѧ����");
		int num = input.nextInt();
		input.nextLine();
		return num;
		}catch(Exception e){
			System.out.println("�����ʽ��������������");
			return -1;//���ط��������ѭ������ѭ��ִ��
		}
	}
	
	//���Ҫɾ��/�޸�/���ҵ�ѧ��ѧ��
	//���ݴ��˲�ͬ�Ĳ���ѡ����Ӧ���������
	public String StuID(int fun){
		try{
		if(fun == 0)
			System.out.println("����Ҫɾ����ѧ��ѧ��");
		else if(fun == 1)
			System.out.println("����Ҫ�޸ĵ�ѧ��ѧ��");
		else 
			System.out.println("����Ҫ���ҵ�ѧ��ѧ��");
		String num = input.nextLine();
		return num;//����ѧ��ѧ��
		}catch(Exception e){
			System.out.println("�����ʽ����");
			return null;//����nullʹ�����ѭ������ѭ��ִ��StuID
		}
	}
	
	//�������ѧ����Ϣ
	public StuAttribute InputStu(int i,boolean fun){
		while(true){
			if(i>0)
				System.out.println("�������"+(i+1)+"��ѧ����������ѧ�ţ��Ա𣬰༶���꼶��Ϣ:");
			else
				System.out.println("������ѧ����������ѧ�ţ��Ա𣬰༶���꼶��Ϣ:\n\t\t[XXX,105XXXXX,�У�2,2013]");
			try{
				String stuName = input.nextLine();
				String stuNo = input.nextLine();
				String stuGender = input.nextLine();
				String stuClass = input.nextLine();
				String stuGrade = input.nextLine();
				StuAttribute sA = new StuAttribute(stuName, stuNo, stuGender, stuClass, stuGrade);
				return sA;//���ظ���ѧ����Ϣ����
			}catch(Exception ex){
				System.out.println("�����ʽ����");
				continue;//�ڱ�����ѭ������֤����ֵ�úϷ���
			}
		}
	}
	
	//ѧ������ϵͳ����ѡ����
	public boolean StuFuncChoice(){
		try{
			boolean temp;
			int choiceNO;
			choiceNO = FunNo();
			switch (choiceNO){
			case 1://��ʾ����ѧ����Ϣ
				stu.ShowStuInfo();
				temp = ConOp();//��ʾ�Ƿ���������
				if(temp)
				return true;//����true���ظ�����
				break;
			case 2://���ѧ����Ϣ
				stu.AddStu();
				stu.SaveStuInfo();
				temp = ConOp();//��ʾ�Ƿ���������
				if(temp)
				return true;//����true���ظ�����
				break;
			case 3://ɾ��ѧ����Ϣ
				stu.delStuInfo();
				temp = ConOp();//��ʾ�Ƿ���������
				if(temp)
				return true;//����true���ظ�����
				break;
			case 4://�޸�ѧ����Ϣ
				stu.ModifyStuInfo();
				temp = ConOp();//��ʾ�Ƿ���������
				if(temp)
				return true;//����true���ظ�����
				break;
			case 5://��ѯѧ����Ϣ
				stu.SeekStuInfo();
				temp = ConOp();//��ʾ�Ƿ���������
				if(temp)
				return true;//����true���ظ�����
				break;
			case 6://����ѧ����Ϣ
				stu.SaveStuInfo();
				temp = ConOp();//��ʾ�Ƿ���������
				if(temp)
				return true;//����true���ظ�����
				break;
			case 7://�˳�ѧ������ϵͳ
				ShowMenuEnd();//��ʾ������
				System.exit(0); //�˳�����
				stu.closedFile();//�رտ������ļ���
				break;
			default:
				System.out.println("����������󣡣���");
				return true;//����true���ѭ����ѭ��ִ�б�����
			}
		}
		//����Ƿ�����
		catch (Exception ex){
			System.out.println("�����ʽ���󣡣���");
			return true;
		}
		return false;
	}	
}
