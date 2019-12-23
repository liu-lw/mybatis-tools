using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.IO;


namespace tools
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Tools : System.Windows.Forms.Form
    {
		private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl controller;
		private System.Windows.Forms.TabPage tabMode;
		private System.Windows.Forms.TabPage tabDao;
		private System.Windows.Forms.TabPage tabServiceImpl;
		private System.Windows.Forms.RichTextBox richModel;
		private System.Windows.Forms.RichTextBox richDao;
		private System.Windows.Forms.RichTextBox richMapper;
        private System.Windows.Forms.RichTextBox richServiceImpl;
        private IContainer components;
		private System.Windows.Forms.TabPage tabMapper;
		private string biaoMing;
		private string packageName;
		private string freTableName;
		private string filepath;
		private string mapperpath;
		private string modelName;
		private string author;
        
        private NotifyIcon notifyIcon1;

   
		public Tools()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.controller = new System.Windows.Forms.TabControl();
			this.tabMode = new System.Windows.Forms.TabPage();
			this.richModel = new System.Windows.Forms.RichTextBox();
			this.tabDao = new System.Windows.Forms.TabPage();
			this.richDao = new System.Windows.Forms.RichTextBox();
			this.tabMapper = new System.Windows.Forms.TabPage();
			this.richMapper = new System.Windows.Forms.RichTextBox();
			this.tabService = new System.Windows.Forms.TabPage();
			this.richService = new System.Windows.Forms.RichTextBox();
			this.tabServiceImpl = new System.Windows.Forms.TabPage();
			this.richServiceImpl = new System.Windows.Forms.RichTextBox();
			this.tabCreate = new System.Windows.Forms.TabPage();
			this.richCreate = new System.Windows.Forms.RichTextBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.controller.SuspendLayout();
			this.tabMode.SuspendLayout();
			this.tabDao.SuspendLayout();
			this.tabMapper.SuspendLayout();
			this.tabService.SuspendLayout();
			this.tabServiceImpl.SuspendLayout();
			this.tabCreate.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.treeView1.Location = new System.Drawing.Point(6, 4);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(152, 513);
			this.treeView1.TabIndex = 3;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// controller
			// 
			this.controller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.controller.Controls.Add(this.tabMode);
			this.controller.Controls.Add(this.tabDao);
			this.controller.Controls.Add(this.tabMapper);
			this.controller.Controls.Add(this.tabService);
			this.controller.Controls.Add(this.tabServiceImpl);
			this.controller.Controls.Add(this.tabCreate);
			this.controller.Location = new System.Drawing.Point(160, 3);
			this.controller.Name = "controller";
			this.controller.SelectedIndex = 0;
			this.controller.Size = new System.Drawing.Size(676, 517);
			this.controller.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.controller.TabIndex = 4;
			this.controller.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabMode
			// 
			this.tabMode.Controls.Add(this.richModel);
			this.tabMode.Location = new System.Drawing.Point(4, 22);
			this.tabMode.Name = "tabMode";
			this.tabMode.Size = new System.Drawing.Size(668, 491);
			this.tabMode.TabIndex = 0;
			this.tabMode.Text = "mode";
			// 
			// richModel
			// 
			this.richModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.richModel.Location = new System.Drawing.Point(0, 0);
			this.richModel.Name = "richModel";
			this.richModel.Size = new System.Drawing.Size(672, 493);
			this.richModel.TabIndex = 0;
			this.richModel.Text = "richModel";
			// 
			// tabDao
			// 
			this.tabDao.Controls.Add(this.richDao);
			this.tabDao.Location = new System.Drawing.Point(4, 22);
			this.tabDao.Name = "tabDao";
			this.tabDao.Size = new System.Drawing.Size(668, 491);
			this.tabDao.TabIndex = 1;
			this.tabDao.Text = "dao";
			// 
			// richDao
			// 
			this.richDao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.richDao.Location = new System.Drawing.Point(0, 0);
			this.richDao.Name = "richDao";
			this.richDao.Size = new System.Drawing.Size(672, 493);
			this.richDao.TabIndex = 0;
			this.richDao.Text = "richDao";
			// 
			// tabMapper
			// 
			this.tabMapper.Controls.Add(this.richMapper);
			this.tabMapper.Location = new System.Drawing.Point(4, 22);
			this.tabMapper.Name = "tabMapper";
			this.tabMapper.Size = new System.Drawing.Size(668, 491);
			this.tabMapper.TabIndex = 2;
			this.tabMapper.Text = "mapper";
			// 
			// richMapper
			// 
			this.richMapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.richMapper.Location = new System.Drawing.Point(0, 3);
			this.richMapper.Name = "richMapper";
			this.richMapper.Size = new System.Drawing.Size(672, 490);
			this.richMapper.TabIndex = 0;
			this.richMapper.Text = "richMapper";
			// 
			// tabService
			// 
			this.tabService.Controls.Add(this.richService);
			this.tabService.Location = new System.Drawing.Point(4, 22);
			this.tabService.Name = "tabService";
			this.tabService.Size = new System.Drawing.Size(668, 491);
			this.tabService.TabIndex = 5;
			this.tabService.Text = "service";
			this.tabService.UseVisualStyleBackColor = true;
			// 
			// richService
			// 
			this.richService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.richService.Location = new System.Drawing.Point(-2, 3);
			this.richService.Name = "richService";
			this.richService.Size = new System.Drawing.Size(672, 485);
			this.richService.TabIndex = 2;
			this.richService.Text = "richService";
			// 
			// tabServiceImpl
			// 
			this.tabServiceImpl.Controls.Add(this.richServiceImpl);
			this.tabServiceImpl.Location = new System.Drawing.Point(4, 22);
			this.tabServiceImpl.Name = "tabServiceImpl";
			this.tabServiceImpl.Size = new System.Drawing.Size(668, 491);
			this.tabServiceImpl.TabIndex = 3;
			this.tabServiceImpl.Text = "serviceImpl";
			// 
			// richServiceImpl
			// 
			this.richServiceImpl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.richServiceImpl.Location = new System.Drawing.Point(0, 0);
			this.richServiceImpl.Name = "richServiceImpl";
			this.richServiceImpl.Size = new System.Drawing.Size(672, 485);
			this.richServiceImpl.TabIndex = 0;
			this.richServiceImpl.Text = "richServiceImpl";
			// 
			// tabCreate
			// 
			this.tabCreate.Controls.Add(this.richCreate);
			this.tabCreate.Location = new System.Drawing.Point(4, 22);
			this.tabCreate.Name = "tabCreate";
			this.tabCreate.Size = new System.Drawing.Size(668, 491);
			this.tabCreate.TabIndex = 6;
			this.tabCreate.Text = "生成到本地";
			this.tabCreate.UseVisualStyleBackColor = true;
			// 
			// richCreate
			// 
			this.richCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.richCreate.Location = new System.Drawing.Point(-2, 3);
			this.richCreate.Name = "richCreate";
			this.richCreate.Size = new System.Drawing.Size(672, 485);
			this.richCreate.TabIndex = 2;
			this.richCreate.Text = "日志记录";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipText = "工具1";
			this.notifyIcon1.BalloonTipTitle = "工具2";
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "工具3";
			this.notifyIcon1.Visible = true;
			// 
			// Tools
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(835, 517);
			this.Controls.Add(this.controller);
			this.Controls.Add(this.treeView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Tools";
			this.Text = "Coder\'s Code";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.controller.ResumeLayout(false);
			this.tabMode.ResumeLayout(false);
			this.tabDao.ResumeLayout(false);
			this.tabMapper.ResumeLayout(false);
			this.tabService.ResumeLayout(false);
			this.tabServiceImpl.ResumeLayout(false);
			this.tabCreate.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox richCreate;
		private System.Windows.Forms.TabPage tabCreate;
		private System.Windows.Forms.RichTextBox richService;
		private System.Windows.Forms.TabPage tabService;
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Tools());
		}
	


		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            if (biaoMing == null || biaoMing == "")
            {
                MessageBox.Show("请选择表名");
                return;
            }
            

			if(controller.SelectedTab==tabDao)
			{
				richDao.Text=createDao();
			}
			if(controller.SelectedTab==tabMapper)
			{
				richMapper.Text=createMapper();
			}
			if(controller.SelectedTab==tabServiceImpl)
			{
				richServiceImpl.Text=createServiceImpl();
			}
			if(controller.SelectedTab==tabService)
			{
				richService.Text=createService();
			}

			if(controller.SelectedTab==tabCreate)
			{
				richCreate.Text=fileCreate();
			}
			
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{            
			biaoMing=e.Node.Text.Trim();
			this.controller.SelectedTab=tabMode;
			this.richModel.Text=createMode();
		}
		
		#region 生成model
		/// <summary>
		/// 生成model
		/// </summary>
		/// <param name="biaoMing"></param>
		/// <returns></returns>
		private string createMode()
		{			
			var tname=biaoMing.Replace(freTableName,"");
			modelName=tname.Substring(0,1).ToString().ToUpper() + tname.Substring(1);
			                           
			string sqlstring="select * from "+biaoMing+" limit 1";
			DataSet ds=MySQLHelper.ExecuteDataSet(sqlstring,null);

			StringBuilder rtbtext=new StringBuilder();
			rtbtext.Append("package "+packageName+".model;\n\n");
            rtbtext.Append("import lombok.Data;\n\n");
            rtbtext.Append("/**\n");
            rtbtext.Append("* @author "+author+" "+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"\n");
			rtbtext.Append("*/\n");
            rtbtext.Append("@Data\n");
            //rtbtext.Append("@TableName(\""+biaoMing+"\")\n");
            rtbtext.Append("public class "+modelName+ "{\n\n"); 

			for(var i=0;i<ds.Tables[0].Columns.Count;i++)
			{				
				DataColumn dc=ds.Tables[0].Columns[i];
				string name=dc.ColumnName;
				string type=GetDataType( dc.DataType.ToString());
//                if(i==0){                	
//                	rtbtext.Append("	@TableId\n");
//                }else{
//                	rtbtext.Append("	@TableField(\""+name+"\")\n");
//                }                
				rtbtext.Append("	private "+type+" "+name+";\n");//这里可以设置是否下划线转驼峰
			}
			rtbtext.Append("}\n");
			return rtbtext.ToString();
		}
		#endregion		
		
		#region 生成dao层
		/// <summary>
		/// 生成dao层
		/// </summary>
		/// <returns></returns>
		private string createDao()
		{			
			string sqlstring="select * from "+biaoMing+" limit 1";			
			DataSet ds=new DataSet();
			int count;
			ds=MySQLHelper.ExecuteDataSet(sqlstring,null);			
			try
			{
				count=ds.Tables[0].Columns.Count;
			}
			catch(Exception ex)
			{
				return ex.Message.ToString();
			}
			string last=ds.Tables[0].Columns[count-1].ToString();			
			
			StringBuilder rtbtext=new StringBuilder();
         	
			rtbtext.Append("package "+packageName+".dao;\n\n");			
            rtbtext.Append("import "+packageName+".model."+modelName+";\n");            
			rtbtext.Append("import org.apache.ibatis.annotations.Mapper;\n");
			rtbtext.Append("import org.apache.ibatis.annotations.Param;\n");	
			rtbtext.Append("import java.util.Map;\n");	
			rtbtext.Append("import java.util.List;\n\n");						
            rtbtext.Append("/**\n");
            rtbtext.Append("* @author "+author+" "+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"\n");
			rtbtext.Append("*/\n");
            rtbtext.Append("@Mapper\n");
            rtbtext.Append("public interface "+modelName+ "Dao{\n\n");             
            rtbtext.Append("	public List<"+modelName+ "> pageList(Map condition);\n");            	
			rtbtext.Append("	public int pageListCount(Map condition);\n");
			rtbtext.Append("	public int findAllCount();\n");			
			rtbtext.Append("	public void save("+modelName+ " model);\n");
			rtbtext.Append("	public "+modelName+ " getById(@Param(\"id\") long id);\n");
			rtbtext.Append("	public void update("+modelName+ " model);\n");	
			rtbtext.Append("	public void delete(@Param(\"id\") long id);\n");	
			rtbtext.Append("}\n");
			return rtbtext.ToString();
		}
		#endregion

        #region 生成mapper
        /// <summary>
		/// 生成mapper
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private string createMapper()
		{
			string sqlstring="select * from "+biaoMing+" limit 1";			
			DataSet ds=new DataSet();
			int count;
			ds=MySQLHelper.ExecuteDataSet(sqlstring,null);			
			try
			{
				count=ds.Tables[0].Columns.Count;
			}
			catch(Exception ex)
			{
				return ex.Message.ToString();
			}
			string last=ds.Tables[0].Columns[count-1].ToString();
			StringBuilder rtbtext=new StringBuilder();			
			rtbtext.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n");
			rtbtext.Append("<!DOCTYPE mapper PUBLIC \"-//mybatis.org//DTD Mapper 3.0//EN\" \"http://mybatis.org/dtd/mybatis-3-mapper.dtd\">\n\n");
			rtbtext.Append("<mapper namespace=\""+packageName+".dao."+modelName+"Dao\">\n");
			rtbtext.Append("	<resultMap id=\""+modelName+"\" type=\""+packageName+".model."+modelName+"\" >\n");			
			
			foreach(DataColumn dc in ds.Tables[0].Columns)
			{
				string lieming=dc.ColumnName;
				rtbtext.Append("		<result column=\""+lieming+"\" property=\""+lieming+"\" />\n");
			}
			rtbtext.Append("	</resultMap>\n\n");
			
			rtbtext.Append("	<sql id=\"Base_Column_List\">\n");
			foreach(DataColumn dc in ds.Tables[0].Columns)
			{
				string lieming=dc.ColumnName;
				if(lieming!=last)								//去掉最后的，号
				{
					rtbtext.Append("		t."+lieming+",\n");
				}
				else
				{
					rtbtext.Append("		t."+lieming+"\n");
				}
			}
			rtbtext.Append("	</sql>\n\n");

		
			rtbtext.Append("	<select id=\"pageList\" parameterType=\"java.util.HashMap\" resultMap=\""+modelName+"\">\n");
			rtbtext.Append("		SELECT <include refid=\"Base_Column_List\" />\n");
			rtbtext.Append("		FROM "+biaoMing+" AS t\n");
			rtbtext.Append("		<trim prefix=\"WHERE\" prefixOverrides=\"AND | OR\" >\n");		
			foreach(DataColumn dc in ds.Tables[0].Columns)
			{
				string lieming=dc.ColumnName;
				rtbtext.Append("			<if test=\""+lieming+" != null and "+lieming+" != ''\">\n");
				rtbtext.Append("				AND t."+lieming+" = #{"+lieming+"}\n");
				rtbtext.Append("			</if>\n");
			}
			
			
			rtbtext.Append("		</trim>\n");
			rtbtext.Append("		ORDER BY id DESC\n");
			rtbtext.Append("		LIMIT #{offset}, #{pagesize}\n");
			rtbtext.Append("	</select>\n\n");

			rtbtext.Append("	<select id=\"pageListCount\" parameterType=\"java.util.HashMap\" resultType=\"int\">\n");
			rtbtext.Append("		SELECT count(1)\n");
			rtbtext.Append("		FROM "+biaoMing+" AS t\n");
			rtbtext.Append("		<trim prefix=\"WHERE\" prefixOverrides=\"AND | OR\" >\n");
			foreach(DataColumn dc in ds.Tables[0].Columns)
			{
				string lieming=dc.ColumnName;
				rtbtext.Append("			<if test=\""+lieming+" != null and "+lieming+" != ''\">\n");
				rtbtext.Append("				AND t."+lieming+" = #{"+lieming+"}\n");
				rtbtext.Append("			</if>\n");
			}			
			rtbtext.Append("		</trim>\n");
			rtbtext.Append("	</select>\n\n");

			rtbtext.Append("	<insert id=\"save\" parameterType=\""+packageName+".model."+modelName+"\" >\n");// useGeneratedKeys=\"true\" keyProperty=\"id\"
			rtbtext.Append("		INSERT INTO "+biaoMing+" (\n");
			foreach(DataColumn dc in ds.Tables[0].Columns)
			{
				string lieming=dc.ColumnName;
				if(lieming!=last)								//去掉最后的，号
				{
					rtbtext.Append("			"+lieming+",\n");
				}
				else
				{
					rtbtext.Append("			"+lieming+"\n");
				}
			}	
			rtbtext.Append("		) VALUES (\n");
			foreach(DataColumn dc in ds.Tables[0].Columns)
			{
				string lieming=dc.ColumnName;
				if(lieming!=last)								//去掉最后的，号
				{
					rtbtext.Append("			#{"+lieming+"},\n");
				}
				else
				{
					rtbtext.Append("			#{"+lieming+"}\n");
				}
			}		
			rtbtext.Append("		)\n");		
			rtbtext.Append("	</insert>\n\n");

			rtbtext.Append("	<select id=\"getById\" parameterType=\"java.util.HashMap\" resultMap=\""+modelName+"\">\n");
			rtbtext.Append("		SELECT <include refid=\"Base_Column_List\" />\n");
			rtbtext.Append("		FROM "+biaoMing+" AS t\n");
			rtbtext.Append("		WHERE t.id = #{id}\n");
			rtbtext.Append("	</select>\n\n");

			rtbtext.Append("	<update id=\"update\" parameterType=\""+packageName+".model."+modelName+"\" >\n");
			rtbtext.Append("		UPDATE "+biaoMing+"\n");
			rtbtext.Append("		<set>\n");
			for(var i=0;i<ds.Tables[0].Columns.Count;i++)			
			{
				DataColumn dc=ds.Tables[0].Columns[i];
				string lieming=dc.ColumnName;
				if(i==0 && lieming.ToLower().Contains("id")){
					continue;
				}
				rtbtext.Append("		<if test=\""+lieming+" != null and "+lieming+" != ''\">\n");
				rtbtext.Append("			"+lieming+" = #{"+lieming+"},\n");
				rtbtext.Append("		</if>\n"); 
			}	
			rtbtext.Append("		<set>\n");
			rtbtext.Append("		WHERE id = #{id}\n");			
			rtbtext.Append("	</update>\n\n");
		
			rtbtext.Append("	<delete id=\"delete\" parameterType=\"java.util.HashMap\">\n");
			rtbtext.Append("		DELETE\n");
			rtbtext.Append("		FROM "+biaoMing+"\n");
			rtbtext.Append("		WHERE id = #{id}\n");
			rtbtext.Append("	</delete>\n\n");
		
		
			rtbtext.Append("	<select id=\"findAllCount\" resultType=\"int\">\n");
			rtbtext.Append("		SELECT count(1)\n");
			rtbtext.Append("		FROM "+biaoMing+"\n");
			rtbtext.Append("	</select>\n\n");
			
			rtbtext.Append("</mapper>\n\n");

			return rtbtext.ToString();
		}
		
        #endregion
		
        #region service
        /// <summary>
        /// service接口
        /// </summary>
        private string createService(){
        	string sqlstring="select * from "+biaoMing+" limit 1";			
			DataSet ds=new DataSet();
			int count;
			ds=MySQLHelper.ExecuteDataSet(sqlstring,null);			
			try
			{
				count=ds.Tables[0].Columns.Count;
			}
			catch(Exception ex)
			{
				return ex.Message.ToString();
			}
			string last=ds.Tables[0].Columns[count-1].ToString();			
			
			StringBuilder rtbtext=new StringBuilder();
         	
			rtbtext.Append("package "+packageName+".service;\n\n");			
            rtbtext.Append("import "+packageName+".model."+modelName+";\n");            
			//rtbtext.Append("import java.util.Date;\n");
			rtbtext.Append("import java.util.List;\n");
			rtbtext.Append("import java.util.Map;\n\n");			
            rtbtext.Append("/**\n");
            rtbtext.Append("* @author "+author+" "+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"\n");
			rtbtext.Append("*/\n");			
			rtbtext.Append("public interface  "+modelName+ "Service{\n\n");        
			rtbtext.Append("	/*\n	* 分页\n	*/\n");			
            rtbtext.Append("	public Map<String, Object> pageList(Map condition);\n");            	
			//rtbtext.Append("	public int pageListCount(int offset,int pagesize,String where);\n");
			rtbtext.Append("	public int findAllCount();\n");			
			rtbtext.Append("	public void save("+modelName+ " model);\n");
			rtbtext.Append("	public "+modelName+ " getById(long id);\n");
			rtbtext.Append("	public void update("+modelName+ " model);\n");	
			rtbtext.Append("	public void delete(long id);\n");	
			rtbtext.Append("}\n");
			return rtbtext.ToString();
        }
        #endregion
        
        #region serviceImpl
        /// <summary>
        /// serviceImpl
        /// </summary>
        private string createServiceImpl(){
        	string sqlstring="select * from "+biaoMing+" limit 1";			
			DataSet ds=new DataSet();
			int count;
			ds=MySQLHelper.ExecuteDataSet(sqlstring,null);			
			try
			{
				count=ds.Tables[0].Columns.Count;
			}
			catch(Exception ex)
			{
				return ex.Message.ToString();
			}
			string last=ds.Tables[0].Columns[count-1].ToString();			
			
			StringBuilder rtbtext=new StringBuilder();
         	
			rtbtext.Append("package "+packageName+".service.impl;\n\n");			
            rtbtext.Append("import "+packageName+".model."+modelName+";\n");            
			rtbtext.Append("import "+packageName+".dao."+modelName+"Dao;\n");
			rtbtext.Append("import "+packageName+".service."+modelName+"Service;\n");
			rtbtext.Append("import org.springframework.stereotype.Service;\n");
			rtbtext.Append("import javax.annotation.Resource;\n");
			rtbtext.Append("import java.util.*;\n\n");
						
            rtbtext.Append("/**\n");
            rtbtext.Append("* @author "+author+" "+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"\n");
			rtbtext.Append("*/\n");
			rtbtext.Append("@Service\n");			
            rtbtext.Append("public class "+modelName+ "ServiceImpl implements "+modelName+"Service{\n\n");        
			rtbtext.Append("	@Resource\n");
			rtbtext.Append("	public "+modelName+"Dao "+modelName.ToLower()+"dao;\n\n");
			rtbtext.Append("	/*\n	* 分页\n	*/\n");
			rtbtext.Append("	@Override\n");
			rtbtext.Append("	public Map<String, Object> pageList(Map condition) {\n");		
			rtbtext.Append("		// page list\n");
			rtbtext.Append("		List<"+modelName+"> list = "+modelName.ToLower()+"dao.pageList(condition);\n");
			rtbtext.Append("		int list_count = "+modelName.ToLower()+"dao.pageListCount(condition);\n");
			rtbtext.Append("		// package result\n");
			rtbtext.Append("		Map<String, Object> maps = new HashMap<String, Object>();\n");
			rtbtext.Append("		maps.put(\"recordsTotal\", list_count);		// 总记录数\n");
			rtbtext.Append("		maps.put(\"recordsFiltered\", list_count);	// 过滤后的总记录数\n");
			rtbtext.Append("		maps.put(\"data\", list);  			// 分页列表\n");
			rtbtext.Append("		return maps;\n");
			rtbtext.Append("	}\n\n");		
		
            rtbtext.Append("	@Override\n");	
			rtbtext.Append("	public int findAllCount(){\n");	
			rtbtext.Append("		return "+modelName.ToLower()+"dao.findAllCount();\n");
			rtbtext.Append("	}\n\n");
			
			rtbtext.Append("	@Override\n");
			rtbtext.Append("	public void save("+modelName+ " model){\n");
			rtbtext.Append("		"+modelName.ToLower()+"dao.save(model);\n");
			rtbtext.Append("	}\n\n");
			
			rtbtext.Append("	@Override\n");
			rtbtext.Append("	public "+modelName+ " getById(long id){\n");
			rtbtext.Append("		return "+modelName.ToLower()+"dao.getById(id);\n");
			rtbtext.Append("	}\n\n");
			
			rtbtext.Append("	@Override\n");
			rtbtext.Append("	public void update("+modelName+ " model){\n");	
			rtbtext.Append("		"+modelName.ToLower()+"dao.update(model);\n");
			rtbtext.Append("	}\n\n");
			
			rtbtext.Append("	@Override\n");
			rtbtext.Append("	public void delete(long id){\n");	
			rtbtext.Append("		"+modelName.ToLower()+"dao.delete(id);\n");
			rtbtext.Append("	}\n\n");
			
			rtbtext.Append("}\n");
			return rtbtext.ToString();
        }
        #endregion
        
        /// <summary>
        /// 文件生成
        /// </summary>
        private string fileCreate(){
        	StringBuilder rtbtext=new StringBuilder();
         	
				
        	var strModel=createMode();
        	WriteFile(strModel,filepath+"model\\"+modelName+".java");
        	rtbtext.Append("生成"+filepath+"model\\"+modelName+".java\n");	
        	
        	var strDao=createDao();
        	WriteFile(strDao,filepath+"dao\\"+modelName+"Dao.java");
        	rtbtext.Append("生成"+filepath+"dao\\"+modelName+"Dao.java\n");	
        	
        	var strMapper=createMapper();
        	WriteFile(strMapper,mapperpath+modelName+"Mapper.xml");
        	rtbtext.Append("生成"+mapperpath+modelName+"Mapper.xml\n");	
        	
        	var strService=createService();
        	WriteFile(strService,filepath+"\\service\\"+modelName+"Service.java");
        	rtbtext.Append("生成"+filepath+"\\service\\"+modelName+"Service.java\n");	
        	
        	var strServiceImpl=createServiceImpl();
        	WriteFile(strServiceImpl,filepath+"service\\impl\\"+modelName+"ServiceImpl.java");
        	rtbtext.Append("生成"+filepath+"service\\impl\\"+modelName+"ServiceImpl.java\n");	
        	
        	return rtbtext.ToString();
        }
        
        

        static void WriteFile(string filecontent,string strpath)
        {
            
            //获取strpath的文件夹名称，并判断不存在是创建文件夹
            if (!Directory.Exists(Path.GetDirectoryName(strpath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(strpath));
            }
            //判断文件不存在时，创建该文件
            if (!File.Exists(strpath))
            {
                File.Create(strpath).Close();//创建完毕后，需关闭该IO通道，以使后续读写可继续进行
            }else{
	            DialogResult result = MessageBox.Show(strpath+"已存在，覆盖？","已存在，覆盖",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
				if(result == DialogResult.No || result == DialogResult.Cancel){ 
				    return;
				}
				          
            }
            //使用数据流写入StreamWriter，true表示可持续写入，Encoding.Default前系统设置的默认字符集编码方式
            var utf8WithoutBom = new System.Text.UTF8Encoding(false);
            StreamWriter sw = new StreamWriter(strpath,false,utf8WithoutBom);
            sw.WriteLine(filecontent);
            //销毁数据数据流通道
            sw.Dispose();
        }
        
        
	
        #region 生成类别
		/// <summary>
		/// 生成类别
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public string GetDataType(string type)
		{
			string type1="";
			switch(type)
			{
				case "System.Int16" :
					type1="int";
					break;
				case "System.Int32" :
					type1="Long";
					break;
				case "System.Int64" :
					type1="Long";
					break;
                
                case "System.Double":
                    type1 = "Double";
                    break;
                case "System.Float":
                    type1 = "Float";
                    break;
                case "System.decimal":
                    type1 = "Decimal";
                    break;
				case "System.String" :
					type1="String";
					break;
				case "System.Boolean" :
					type1="Bool";
					break;
				case "System.DateTime" :
					type1="String";
					break;
			}
			return type1;
		}
        #endregion

        #region 取得类别的大小
        /// <summary>
		/// 取得类别的大小
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public int GetSize(string type)
		{
			int size=0;
			switch(type)
			{
				case "int":
					size=4;
					break;
				case "string":
					size=50;
					break;
				case "bool" :
					size=1;
					break;
				case "DateTime":
					size=0;
					break;
				case "float":
					size=4;
					break;
				case "double":
					size=8;
					break;
				case "decimal":
					size=16;
					break;
			}
			return size;
		}
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {            
			packageName=ConfigurationSettings.AppSettings["packageName"];
			filepath=ConfigurationSettings.AppSettings["filepath"];
			mapperpath=ConfigurationSettings.AppSettings["mapperpath"];
			freTableName=ConfigurationSettings.AppSettings["freTableName"];
			author=ConfigurationSettings.AppSettings["author"];
            string sqlstring = "show tables";
            DataSet ds = new DataSet();
            int count;
            
            ds=MySQLHelper.ExecuteDataSet(sqlstring,null);
            try
            {
                count = ds.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                string excp = ex.Message.ToString();
                return;
            }
            for (int i = 0; i < count; i++)
            {
                string nodes = ds.Tables[0].Rows[i][0].ToString();
                TreeNode node = new TreeNode(nodes);
                this.treeView1.Nodes.Add(nodes);
            } 
        }

	}
}
