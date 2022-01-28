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
		<Item Name="UserProgramNewtonSolver.vi" Type="VI" URL="../UserProgramNewtonSolver.vi"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="FunctionSolverQuadratic.vi" Type="VI" URL="../FunctionSolverQuadratic.vi"/>
			<Item Name="FunctionSolverQuadraticDifferentiated.vi" Type="VI" URL="../FunctionSolverQuadraticDifferentiated.vi"/>
			<Item Name="NewtonSolverForSquareFunctions.vi" Type="VI" URL="../NewtonSolverForSquareFunctions.vi"/>
		</Item>
		<Item Name="Build Specifications" Type="Build"/>
	</Item>
</Project>
