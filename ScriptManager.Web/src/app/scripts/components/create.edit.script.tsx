"use client";

import { useState } from "react";
export default function CreateEditScript({ data }: any) {
  const [value, setValue] = useState("1");
  const [script, setScript] = useState<any>(data);

  const handleChange = (event: React.SyntheticEvent, newValue: string) => {
    setValue(newValue);
  };
  function onChange({ target }: any) {
    let currentScript = { ...script, [target.name]: target.value };
    setScript(currentScript);
  }
  return (
    <>
      <div className="row">
        <div className="col">
          <h1>
            <b> Edit</b>
          </h1>
        </div>
      </div>
      <div className="row">
        <div className="col">
          <div className="card shadow">
            <div className="card-body ">
              <div className="row">
                <div className="col d-flex justify-content-end">
                  <button className="btn btn-dark "> Save</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div className="row mt-5">
        <div className="col col-sm-4">
          <ul className="list-group shadow">
            <li className="list-group-item">Script</li>
            <li className="list-group-item">Questions</li>
          </ul>
        </div>
        <div className="col">
          <div className="card shadow">
            <div className="card-body">
              <div className="row">
                <div className="col">
                  <h3>
                    <b>Information</b>
                  </h3>
                </div>
              </div>
              <form className=" was-validated">
                <div className="row mt-3">
                  <div className="col">
                    <label htmlFor="name" className="form-label">
                      Name
                    </label>
                    <input
                      name="name"
                      onChange={onChange}
                      type="text"
                      className="form-control"
                      id="name"
                      value={script.name}
                      required
                    />
                    <div className="invalid-feedback">Please add a name</div>
                  </div>
                </div>
                <div className="row mt-3">
                  <div className="col">
                    <label htmlFor="description" className="form-label">
                      Description
                    </label>
                    <input
                      name="description"
                      onChange={onChange}
                      type="text"
                      className="form-control"
                      id="description"
                      value={script.description}
                      required
                    />
                    <div className="invalid-feedback">
                      Please add a description
                    </div>
                  </div>
                </div>
                <div className="row mt-3">
                  <div className="col">
                    <button type="submit" className="btn btn-dark">
                      Submit
                    </button>
                  </div>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}
