<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="21008000">
	<Item Name="My Computer" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="Main" Type="Folder">
			<Item Name="Datalogger.vi" Type="VI" URL="../Datalogger.vi"/>
		</Item>
		<Item Name="SubVIs" Type="Folder">
			<Item Name="ConfigurateDatabase.vi" Type="VI" URL="../ConfigurateDatabase.vi"/>
			<Item Name="Temperature_value_randomizer.vi" Type="VI" URL="../Temperature_value_randomizer.vi"/>
		</Item>
		<Item Name="Model - Air Heater.vi" Type="VI" URL="../../../HIL/Model - Air Heater.vi"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="ADODBCommand Create.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBCommand Create.vi"/>
				<Item Name="ADODBCommand Destroy.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBCommand Destroy.vi"/>
				<Item Name="ADODBCommand Execute.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBCommand Execute.vi"/>
				<Item Name="ADODBCommand Set Active Connection.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBCommand Set Active Connection.vi"/>
				<Item Name="ADODBCommand Set Command Text.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBCommand Set Command Text.vi"/>
				<Item Name="ADODBConnection Close.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBConnection Close.vi"/>
				<Item Name="ADODBConnection Create.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBConnection Create.vi"/>
				<Item Name="ADODBConnection Destroy.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBConnection Destroy.vi"/>
				<Item Name="ADODBConnection Execute.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBConnection Execute.vi"/>
				<Item Name="ADODBConnection Open.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBConnection Open.vi"/>
				<Item Name="ADODBField Get String Value.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBField Get String Value.vi"/>
				<Item Name="ADODBFields Get Count.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBFields Get Count.vi"/>
				<Item Name="ADODBFields Item.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBFields Item.vi"/>
				<Item Name="ADODBRecordset Destroy.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBRecordset Destroy.vi"/>
				<Item Name="ADODBRecordset Get Fields.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBRecordset Get Fields.vi"/>
				<Item Name="ADODBRecordset Get Row String Value.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBRecordset Get Row String Value.vi"/>
				<Item Name="ADODBRecordset Get Table String Value.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/ADODBRecordset Get Table String Value.vi"/>
				<Item Name="Clear Errors.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Clear Errors.vi"/>
				<Item Name="ex_BuildTextVarProps.ctl" Type="VI" URL="/&lt;vilib&gt;/express/express output/BuildTextBlock.llb/ex_BuildTextVarProps.ctl"/>
				<Item Name="ex_CorrectErrorChain.vi" Type="VI" URL="/&lt;vilib&gt;/express/express shared/ex_CorrectErrorChain.vi"/>
				<Item Name="NILVSim.dll" Type="Document" URL="/&lt;vilib&gt;/Simulation/Implementation/Shared/NILVSim.dll"/>
				<Item Name="SIM limit type.ctl" Type="VI" URL="/&lt;vilib&gt;/Simulation/Implementation/Shared/SIM limit type.ctl"/>
				<Item Name="SQL Close.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/SQL Close.vi"/>
				<Item Name="SQL Execute.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/SQL Execute.vi"/>
				<Item Name="SQL Open.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/SQL Open.vi"/>
				<Item Name="SQL Select.vi" Type="VI" URL="/&lt;vilib&gt;/SQLToolkit.llb/SQL Select.vi"/>
			</Item>
		</Item>
		<Item Name="Build Specifications" Type="Build"/>
	</Item>
</Project>
