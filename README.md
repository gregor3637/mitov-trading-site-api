## Setup Instructions

1. **Execute Solution File**: Open `Investments.Web.sln` in your preferred IDE or text editor.

2. **Start Server**: Run the server using HTTPS protocol.

3. **Wait for Browser**: A new tab in your default web browser should automatically open at https://localhost:7047/swagger/index.html.

4. **Download Frontend Repository**: Clone or download the frontend repository from [mitov-trading-site](https://github.com/gregor3637/mitov-trading-site).

5. **Install Dependencies**: Navigate to the frontend project directory and install dependencies by running: npm install

6. **Run the Project**: Once dependencies are installed, start the project by running: npm start

7. **Test the project**: The project should consume the APIs provided by BE 

8. **Ensure Connection**:
- If the frontend is not connecting to the backend (hopefully this does not happen):
  - Open `api.js` located in the frontend repository.
  - Verify that the `baseURL` provided to Axios (located at the very start of the file) matches the backend URL.
  - For example, if the backend is hosted at `https://localhost:7047/`, ensure the Axios `baseURL` is set to `https://localhost:7047/Investments`.