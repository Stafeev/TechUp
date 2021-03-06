﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanViewer.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TeamProjectDB")]
	public partial class DBClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertContractor(Contractor instance);
    partial void UpdateContractor(Contractor instance);
    partial void DeleteContractor(Contractor instance);
    partial void InsertPlan(Plan instance);
    partial void UpdatePlan(Plan instance);
    partial void DeletePlan(Plan instance);
    partial void InsertFact(Fact instance);
    partial void UpdateFact(Fact instance);
    partial void DeleteFact(Fact instance);
    #endregion
		
		public DBClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TeamProjectDBConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Contractor> Contractors
		{
			get
			{
				return this.GetTable<Contractor>();
			}
		}
		
		public System.Data.Linq.Table<Plan> Plans
		{
			get
			{
				return this.GetTable<Plan>();
			}
		}
		
		public System.Data.Linq.Table<Fact> Facts
		{
			get
			{
				return this.GetTable<Fact>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Address;
		
		private string _Info;
		
		private string _Password;
		
		private EntitySet<Plan> _Plans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnInfoChanging(string value);
    partial void OnInfoChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Customer()
		{
			this._Plans = new EntitySet<Plan>(new Action<Plan>(this.attach_Plans), new Action<Plan>(this.detach_Plans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Info", DbType="NVarChar(50)")]
		public string Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				if ((this._Info != value))
				{
					this.OnInfoChanging(value);
					this.SendPropertyChanging();
					this._Info = value;
					this.SendPropertyChanged("Info");
					this.OnInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Plan", Storage="_Plans", ThisKey="ID", OtherKey="Customer")]
		public EntitySet<Plan> Plans
		{
			get
			{
				return this._Plans;
			}
			set
			{
				this._Plans.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Customer1 = this;
		}
		
		private void detach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Customer1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contractor")]
	public partial class Contractor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Address;
		
		private string _Info;
		
		private string _Password;
		
		private EntitySet<Plan> _Plans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnInfoChanging(string value);
    partial void OnInfoChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Contractor()
		{
			this._Plans = new EntitySet<Plan>(new Action<Plan>(this.attach_Plans), new Action<Plan>(this.detach_Plans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Info", DbType="NVarChar(50)")]
		public string Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				if ((this._Info != value))
				{
					this.OnInfoChanging(value);
					this.SendPropertyChanging();
					this._Info = value;
					this.SendPropertyChanged("Info");
					this.OnInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Contractor_Plan", Storage="_Plans", ThisKey="ID", OtherKey="Contractor")]
		public EntitySet<Plan> Plans
		{
			get
			{
				return this._Plans;
			}
			set
			{
				this._Plans.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Contractor1 = this;
		}
		
		private void detach_Plans(Plan entity)
		{
			this.SendPropertyChanging();
			entity.Contractor1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Plan]")]
	public partial class Plan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Object;
		
		private string _WorkType;
		
		private string _UnitName;
		
		private string _CostName;
		
		private string _Labor;
		
		private string _Materials;
		
		private string _Mechanisms;
		
		private System.Nullable<int> _Customer;
		
		private System.Nullable<int> _Contractor;
		
		private int _Status;
		
		private int _PlanID;
		
		private System.Nullable<System.DateTime> _Date;
		
		private EntitySet<Fact> _Facts;
		
		private EntityRef<Contractor> _Contractor1;
		
		private EntityRef<Customer> _Customer1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnObjectChanging(string value);
    partial void OnObjectChanged();
    partial void OnWorkTypeChanging(string value);
    partial void OnWorkTypeChanged();
    partial void OnUnitNameChanging(string value);
    partial void OnUnitNameChanged();
    partial void OnCostNameChanging(string value);
    partial void OnCostNameChanged();
    partial void OnLaborChanging(string value);
    partial void OnLaborChanged();
    partial void OnMaterialsChanging(string value);
    partial void OnMaterialsChanged();
    partial void OnMechanismsChanging(string value);
    partial void OnMechanismsChanged();
    partial void OnCustomerChanging(System.Nullable<int> value);
    partial void OnCustomerChanged();
    partial void OnContractorChanging(System.Nullable<int> value);
    partial void OnContractorChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    partial void OnPlanIDChanging(int value);
    partial void OnPlanIDChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    #endregion
		
		public Plan()
		{
			this._Facts = new EntitySet<Fact>(new Action<Fact>(this.attach_Facts), new Action<Fact>(this.detach_Facts));
			this._Contractor1 = default(EntityRef<Contractor>);
			this._Customer1 = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Object", DbType="NVarChar(50)")]
		public string Object
		{
			get
			{
				return this._Object;
			}
			set
			{
				if ((this._Object != value))
				{
					this.OnObjectChanging(value);
					this.SendPropertyChanging();
					this._Object = value;
					this.SendPropertyChanged("Object");
					this.OnObjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkType", DbType="NVarChar(50)")]
		public string WorkType
		{
			get
			{
				return this._WorkType;
			}
			set
			{
				if ((this._WorkType != value))
				{
					this.OnWorkTypeChanging(value);
					this.SendPropertyChanging();
					this._WorkType = value;
					this.SendPropertyChanged("WorkType");
					this.OnWorkTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitName", DbType="NVarChar(50)")]
		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				if ((this._UnitName != value))
				{
					this.OnUnitNameChanging(value);
					this.SendPropertyChanging();
					this._UnitName = value;
					this.SendPropertyChanged("UnitName");
					this.OnUnitNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CostName", DbType="NVarChar(50)")]
		public string CostName
		{
			get
			{
				return this._CostName;
			}
			set
			{
				if ((this._CostName != value))
				{
					this.OnCostNameChanging(value);
					this.SendPropertyChanging();
					this._CostName = value;
					this.SendPropertyChanged("CostName");
					this.OnCostNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Labor", DbType="NVarChar(50)")]
		public string Labor
		{
			get
			{
				return this._Labor;
			}
			set
			{
				if ((this._Labor != value))
				{
					this.OnLaborChanging(value);
					this.SendPropertyChanging();
					this._Labor = value;
					this.SendPropertyChanged("Labor");
					this.OnLaborChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materials", DbType="NVarChar(50)")]
		public string Materials
		{
			get
			{
				return this._Materials;
			}
			set
			{
				if ((this._Materials != value))
				{
					this.OnMaterialsChanging(value);
					this.SendPropertyChanging();
					this._Materials = value;
					this.SendPropertyChanged("Materials");
					this.OnMaterialsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mechanisms", DbType="NVarChar(50)")]
		public string Mechanisms
		{
			get
			{
				return this._Mechanisms;
			}
			set
			{
				if ((this._Mechanisms != value))
				{
					this.OnMechanismsChanging(value);
					this.SendPropertyChanging();
					this._Mechanisms = value;
					this.SendPropertyChanged("Mechanisms");
					this.OnMechanismsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer", DbType="Int")]
		public System.Nullable<int> Customer
		{
			get
			{
				return this._Customer;
			}
			set
			{
				if ((this._Customer != value))
				{
					if (this._Customer1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerChanging(value);
					this.SendPropertyChanging();
					this._Customer = value;
					this.SendPropertyChanged("Customer");
					this.OnCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contractor", DbType="Int")]
		public System.Nullable<int> Contractor
		{
			get
			{
				return this._Contractor;
			}
			set
			{
				if ((this._Contractor != value))
				{
					if (this._Contractor1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnContractorChanging(value);
					this.SendPropertyChanging();
					this._Contractor = value;
					this.SendPropertyChanged("Contractor");
					this.OnContractorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int NOT NULL")]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlanID", DbType="Int NOT NULL")]
		public int PlanID
		{
			get
			{
				return this._PlanID;
			}
			set
			{
				if ((this._PlanID != value))
				{
					this.OnPlanIDChanging(value);
					this.SendPropertyChanging();
					this._PlanID = value;
					this.SendPropertyChanged("PlanID");
					this.OnPlanIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Plan_Fact", Storage="_Facts", ThisKey="ID", OtherKey="ExtPlanID")]
		public EntitySet<Fact> Facts
		{
			get
			{
				return this._Facts;
			}
			set
			{
				this._Facts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Contractor_Plan", Storage="_Contractor1", ThisKey="Contractor", OtherKey="ID", IsForeignKey=true)]
		public Contractor Contractor1
		{
			get
			{
				return this._Contractor1.Entity;
			}
			set
			{
				Contractor previousValue = this._Contractor1.Entity;
				if (((previousValue != value) 
							|| (this._Contractor1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Contractor1.Entity = null;
						previousValue.Plans.Remove(this);
					}
					this._Contractor1.Entity = value;
					if ((value != null))
					{
						value.Plans.Add(this);
						this._Contractor = value.ID;
					}
					else
					{
						this._Contractor = default(Nullable<int>);
					}
					this.SendPropertyChanged("Contractor1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Plan", Storage="_Customer1", ThisKey="Customer", OtherKey="ID", IsForeignKey=true)]
		public Customer Customer1
		{
			get
			{
				return this._Customer1.Entity;
			}
			set
			{
				Customer previousValue = this._Customer1.Entity;
				if (((previousValue != value) 
							|| (this._Customer1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer1.Entity = null;
						previousValue.Plans.Remove(this);
					}
					this._Customer1.Entity = value;
					if ((value != null))
					{
						value.Plans.Add(this);
						this._Customer = value.ID;
					}
					else
					{
						this._Customer = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Facts(Fact entity)
		{
			this.SendPropertyChanging();
			entity.Plan = this;
		}
		
		private void detach_Facts(Fact entity)
		{
			this.SendPropertyChanging();
			entity.Plan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fact")]
	public partial class Fact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FactObject;
		
		private string _WorkType;
		
		private string _UnitName;
		
		private string _CostName;
		
		private string _Labor;
		
		private string _Materials;
		
		private string _Mechanisms;
		
		private System.Nullable<int> _ExtPlanID;
		
		private System.Nullable<System.DateTime> _Date;
		
		private System.Nullable<int> _FactID;
		
		private System.Nullable<int> _Status;
		
		private EntityRef<Plan> _Plan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFactObjectChanging(string value);
    partial void OnFactObjectChanged();
    partial void OnWorkTypeChanging(string value);
    partial void OnWorkTypeChanged();
    partial void OnUnitNameChanging(string value);
    partial void OnUnitNameChanged();
    partial void OnCostNameChanging(string value);
    partial void OnCostNameChanged();
    partial void OnLaborChanging(string value);
    partial void OnLaborChanged();
    partial void OnMaterialsChanging(string value);
    partial void OnMaterialsChanged();
    partial void OnMechanismsChanging(string value);
    partial void OnMechanismsChanged();
    partial void OnExtPlanIDChanging(System.Nullable<int> value);
    partial void OnExtPlanIDChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnFactIDChanging(System.Nullable<int> value);
    partial void OnFactIDChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    #endregion
		
		public Fact()
		{
			this._Plan = default(EntityRef<Plan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactObject", DbType="NVarChar(50)")]
		public string FactObject
		{
			get
			{
				return this._FactObject;
			}
			set
			{
				if ((this._FactObject != value))
				{
					this.OnFactObjectChanging(value);
					this.SendPropertyChanging();
					this._FactObject = value;
					this.SendPropertyChanged("FactObject");
					this.OnFactObjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkType", DbType="NVarChar(50)")]
		public string WorkType
		{
			get
			{
				return this._WorkType;
			}
			set
			{
				if ((this._WorkType != value))
				{
					this.OnWorkTypeChanging(value);
					this.SendPropertyChanging();
					this._WorkType = value;
					this.SendPropertyChanged("WorkType");
					this.OnWorkTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitName", DbType="NVarChar(50)")]
		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				if ((this._UnitName != value))
				{
					this.OnUnitNameChanging(value);
					this.SendPropertyChanging();
					this._UnitName = value;
					this.SendPropertyChanged("UnitName");
					this.OnUnitNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CostName", DbType="NVarChar(50)")]
		public string CostName
		{
			get
			{
				return this._CostName;
			}
			set
			{
				if ((this._CostName != value))
				{
					this.OnCostNameChanging(value);
					this.SendPropertyChanging();
					this._CostName = value;
					this.SendPropertyChanged("CostName");
					this.OnCostNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Labor", DbType="NVarChar(50)")]
		public string Labor
		{
			get
			{
				return this._Labor;
			}
			set
			{
				if ((this._Labor != value))
				{
					this.OnLaborChanging(value);
					this.SendPropertyChanging();
					this._Labor = value;
					this.SendPropertyChanged("Labor");
					this.OnLaborChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materials", DbType="NVarChar(50)")]
		public string Materials
		{
			get
			{
				return this._Materials;
			}
			set
			{
				if ((this._Materials != value))
				{
					this.OnMaterialsChanging(value);
					this.SendPropertyChanging();
					this._Materials = value;
					this.SendPropertyChanged("Materials");
					this.OnMaterialsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mechanisms", DbType="NVarChar(50)")]
		public string Mechanisms
		{
			get
			{
				return this._Mechanisms;
			}
			set
			{
				if ((this._Mechanisms != value))
				{
					this.OnMechanismsChanging(value);
					this.SendPropertyChanging();
					this._Mechanisms = value;
					this.SendPropertyChanged("Mechanisms");
					this.OnMechanismsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtPlanID", DbType="Int")]
		public System.Nullable<int> ExtPlanID
		{
			get
			{
				return this._ExtPlanID;
			}
			set
			{
				if ((this._ExtPlanID != value))
				{
					if (this._Plan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExtPlanIDChanging(value);
					this.SendPropertyChanging();
					this._ExtPlanID = value;
					this.SendPropertyChanged("ExtPlanID");
					this.OnExtPlanIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactID", DbType="Int")]
		public System.Nullable<int> FactID
		{
			get
			{
				return this._FactID;
			}
			set
			{
				if ((this._FactID != value))
				{
					this.OnFactIDChanging(value);
					this.SendPropertyChanging();
					this._FactID = value;
					this.SendPropertyChanged("FactID");
					this.OnFactIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Plan_Fact", Storage="_Plan", ThisKey="ExtPlanID", OtherKey="ID", IsForeignKey=true)]
		public Plan Plan
		{
			get
			{
				return this._Plan.Entity;
			}
			set
			{
				Plan previousValue = this._Plan.Entity;
				if (((previousValue != value) 
							|| (this._Plan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Plan.Entity = null;
						previousValue.Facts.Remove(this);
					}
					this._Plan.Entity = value;
					if ((value != null))
					{
						value.Facts.Add(this);
						this._ExtPlanID = value.ID;
					}
					else
					{
						this._ExtPlanID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Plan");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
