import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateEditScriptComponent } from './create-edit-script.component';

describe('CreateEditScriptComponent', () => {
  let component: CreateEditScriptComponent;
  let fixture: ComponentFixture<CreateEditScriptComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateEditScriptComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateEditScriptComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
