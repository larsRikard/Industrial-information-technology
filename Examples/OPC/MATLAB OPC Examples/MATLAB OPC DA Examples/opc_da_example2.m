% OPC Example
%(C) Hans-Petter Halvorsen
clear, clc

% Connect to OPC Server
da = opcda('localhost', 'Matrikon.OPC.Simulation.1');
connect(da);

% Create Group
grp = addgroup(da, 'DemoGroup');

%Add Tags
itmIDs = {'Random.Real8'};
itm = additem(grp, itmIDs);

N=10;
for i=1:N

    % Retrieve Data
    data = read(grp);

    opcdata(i) = data.Value;

    pause(2)

end

%Clean Up
disconnect(da)
delete(da)

plot(opcdata)

