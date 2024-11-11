import React from "react";

const address = "http://localhost:5069";

function TestButton() {
  async function fetchFromServer() {
    try {
      const result = await fetch(`${address}/api/Chat/getMessage`);
      console.log(result);
      console.log(result.json());
    } catch (error) {
      console.log(`Error with server: ${error}`);
    }
  }

  return <button onClick={fetchFromServer}>Test server connection</button>;
}

export default TestButton;
