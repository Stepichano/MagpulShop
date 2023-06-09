import React, { useEffect, useState } from "react";
import { Modal, Form, Button } from "react-bootstrap";
import { UserService } from "../../services/user.service";

const useValidation = (value, validations) => {
  const [isEmpty, setEmpty] = useState(true);
  const [minlengthError, setMinlegthError] = useState(false);

  useEffect(() => {
    for (const validation in validations) {
      switch (validation) {
        case "minlength":
          value.length < validations[validation]
            ? setMinlegthError(true)
            : setMinlegthError(false);
          break;
        case "isEmpty":
          value ? setEmpty(false) : setEmpty(true);
          break;
        default:
          break;
      }
    }
  }, [value, validations]);

  return {
    isEmpty,
    minlengthError,
  };
};

const useInput = (initialValue, validations) => {
  const [value, setValue] = useState(initialValue);
  const [isDirty, setDirty] = useState(false);
  const valid = useValidation(value, validations);

  const onChange = (e) => {
    setDirty(false);
    setValue(e.target.value);
  };

  const onBlur = (e) => {
    setDirty(true);
  };

  return {
    value,
    onChange,
    onBlur,
    isDirty,
    ...valid,
  };
};

const FormAuthorization = ({ show, handleClose }) => {
  const email = useInput("", { isEmpty: true, minlength: 3 });
  const password = useInput("", { isEmpty: true, minlength: 5 });

   const handleRegisterClick = async() => {

      const response = await UserService.registerUser({email : email.value, password: password.value});
      console.log(response.status);

  }

  return (
    <>
      <Modal show={show} onHide={handleClose}>
        <Modal.Header closeButton>
          <Modal.Title className="modalText fw-bold">
            Личный кабинет
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <Form>
            <Form.Group controlId="fromBasicEmail">
              <Form.Label className="modalText">Логин или email</Form.Label>
              {email.isDirty && email.isEmpty && (
                <div className="text-danger">
                  Поле email не может быть пустым
                </div>
              )}
              <Form.Control
                type="email"
                name="email"
                placeholder="Введите логин или email"
                onChange={(e) => email.onChange(e)}
                onBlur={(e) => email.onBlur(e)}
                value={email.value}
                className="is-invalid"
                required
              />
              <Form.Text className="text-muted ">
                Не беспокойтесь, мы никогда не поделимся данными.
              </Form.Text>
            </Form.Group>
            <Form.Group controlId="fromBasicPassword">
              <Form.Label className="modalText">Пароль</Form.Label>
              {password.isDirty && password.isEmpty && (
                <div className="text-danger">
                  Поле пароль не может быть пустым
                </div>
              )}
              <Form.Control
                type="password"
                name="password"
                placeholder="Введите пароль"
                onChange={(e) => password.onChange(e)}
                onBlur={(e) => password.onBlur(e)}
                value={password.value}
                className="emailError is-invalid"
                required
              />
            </Form.Group>
          </Form>
        </Modal.Body>
        <Modal.Footer>
          <Button className="logButton" type="submint">
            Войти
          </Button>
          <Button type="submit" onClick={handleRegisterClick}>Регистрация</Button>
        </Modal.Footer>
      </Modal>
    </>
  );
};

export default FormAuthorization;
