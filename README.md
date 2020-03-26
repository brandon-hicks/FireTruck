FireTruckApp

This app was designed to do calculations that are vital to fire ground operations. These include calculating friction loss and total pump discharge pressure that a fire apparatus is to be pumped at. 

To get to information the route would be: 
```http://localhost:5001/api/GetCalculationResponse```

The response that can be expected looks like the following.
```
{
     "frictionLoss": 61.49453881190399,
     "pumpDischargePressure": 111.494538811904,
     "tipSize": 0.88,
     "hoseLength": 150,
     "hoseSize": 1.75
   }
```

The default tips size is 7/8 and the default hose size is 1 3/4 and the default hose length is 200.

To update the information to find the desired friction loss and pump discharge pressure the route would be:
```http://localhost:5001/api/UpdateCalculationRequest```

If the following information was entered:
```
{
	"HoseLength": 200,
	"tipSize": 2.0,
	"HoseSize": 2.5
}
```

The response that can be expected would look like the following:
```
{
     "frictionLoss": 282.2688,
     "pumpDischargePressure": 332.2688,
     "tipSize": 2,
     "hoseLength": 200,
     "hoseSize": 2.5
   }
```
When the values are updated the values will persist as long as the app is running.

Soon entire app will run in a docker container.