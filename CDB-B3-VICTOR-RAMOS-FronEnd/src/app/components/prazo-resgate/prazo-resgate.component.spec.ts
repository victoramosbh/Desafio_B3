import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrazoResgateComponent } from './prazo-resgate.component';

describe('PrazoResgateComponent', () => {
  let component: PrazoResgateComponent;
  let fixture: ComponentFixture<PrazoResgateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PrazoResgateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PrazoResgateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
