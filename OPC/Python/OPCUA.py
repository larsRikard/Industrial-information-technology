import asyncio
from asyncua.client import Client
import time

async def read_file():
    """https://github.com/FreeOpcUa/opcua-asyncio/blob/master/examples/client_to_kepware.py"""
    url = "opc.tcp://DESKTOP-IM0LL0U:49580"
    async with Client(url=url) as client:
        while True:
        # Do something with client
            node = client.get_node('ns=2;s=Process Data.Temperature')
            print(f"tag1 is: {node} with value {await node.read_value()} ")
            time.sleep(1)
if __name__ == "__main__":
    print("-----------")
    asyncio.run(read_file())