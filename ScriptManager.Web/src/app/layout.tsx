import "./globals.css";
import "bootstrap/dist/css/bootstrap.min.css";
// import "bootstrap/dist/js/bootstrap.bundle";
// import "@fontsource/roboto/300.css";
// import "@fontsource/roboto/400.css";
// import "@fontsource/roboto/500.css";
// import "@fontsource/roboto/700.css";
import { Inter } from "@next/font/google";

import NavBar from "./navbar";
import Link from "next/link";
const inter = Inter({
  subsets: ["latin"],
  display: "swap",
});

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en" className={inter.className}>
      {/*
        <head /> will contain the components returned by the nearest parent
        head.tsx. Find out more at https://beta.nextjs.org/docs/api-reference/file-conventions/head
      */}
      <head />
      <body>
        <div className="container-fluid p-0">
          <div className="container-fluid">
            <div className="row flex-nowrap">
              <div className="col-auto col-md-3 col-xl-2 px-sm-2 px-0 bg-dark">
                <div className="d-flex flex-column align-items-center align-items-sm-start px-3 pt-2 text-white min-vh-100">
                  <Link
                    href="/"
                    className="d-flex align-items-center pb-3 mb-md-0 me-md-auto text-white text-decoration-none"
                  >
                    <h3 className="fs-5 d-none d-sm-inline">
                      {" "}
                      <b> Centro Script</b>
                    </h3>
                  </Link>
                  <ul
                    className="nav nav-pills flex-column mb-sm-auto mb-0 align-items-center align-items-sm-start"
                    id="menu"
                  >
                    <li>
                      <Link
                        href="/scripts"
                        data-bs-toggle="collapse"
                        className="nav-link px-0 align-middle"
                      >
                        <i className="fs-4 bi-speedometer2"></i>{" "}
                        <h5 className="ms-1 d-none d-sm-inline text-white">
                          <b> Scripts</b>
                        </h5>
                      </Link>
                    </li>
                  </ul>
                </div>
              </div>
              <div className="col py-3">{children}</div>
            </div>
          </div>
        </div>
      </body>
    </html>
  );
}
