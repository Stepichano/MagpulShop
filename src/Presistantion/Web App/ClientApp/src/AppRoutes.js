import { Home } from "./components/Home";
import { Catalog } from "./Pages/Catalog";

const AppRoutes = [
  {
    index: true,
    element: <Home />,
  },
  {
    path: "./Pages/Catalog.js",
    element: <Catalog />,
  },
];

export default AppRoutes;
