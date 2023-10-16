import { Home } from "./components/Home";
import { Input } from "./components/Input";


const AppRoutes = [
  {
    index: true,
    element: <Home/>
  },
    {
        path: '/input',
        element: <Input/>
    }
];

export default AppRoutes;
