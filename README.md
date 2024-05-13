# Crystal Sharp - Message Broker Azure Service Bus Example
Crystal Sharp framework - `Message Broker` code example with `Azure Service Bus`.


### About This Example
This example uses `Azure Service Bus` as a message broker.

`WebAPI` project sends the message to a message broker.
`Console` application receives the message from the message queue.


### How to Run

* Change the `Azure Service Bus` connection in `appsettings.json` file in the `WebAPI` project.
* Change the `Azure Service Bus` connection in `appsettings.json` file in the `Console` application.
* Change the `Queue` name in the `OrderController.cs` file.
* Change the `Queue` name in the `Console` application `Program.cs` file.
* `Queue` name must exist on the `Azure Service Bus`.
* Run the `WebAPI` project and `Console` application.
