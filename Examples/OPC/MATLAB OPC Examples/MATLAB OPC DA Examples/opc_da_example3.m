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
itm = additem(grp, itmIDs)

% Set Properties
logDuration = 60;
logRate = 0.2;
numRecords = ceil(logDuration./logRate);
grp.UpdateRate = logRate;
grp.RecordsToAcquire = numRecords;

% Acquire Data
start(grp)
wait(grp)

% Retrieve Data
[logIDs, logVal, logQual, logTime, logEvtTime] = getdata(grp, 'double');

% Plot Data
plot(logTime, logVal);
axis tight
datetick('x', 'keeplimits')
legend(logIDs)

%Clean Up
disconnect(da)
delete(da)
