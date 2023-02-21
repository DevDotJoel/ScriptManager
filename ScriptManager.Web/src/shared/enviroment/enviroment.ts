export const apiUrl =
  process.env.NODE_ENV === "development"
    ? "http://localhost:5219/"
    : "https://scriptmanagerapi.azurewebsites.net/";
