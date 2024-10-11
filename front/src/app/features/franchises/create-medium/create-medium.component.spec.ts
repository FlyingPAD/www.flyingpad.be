import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateMediumComponent } from './create-medium.component';

describe('CreateMediumComponent', () => {
  let component: CreateMediumComponent;
  let fixture: ComponentFixture<CreateMediumComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateMediumComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateMediumComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
